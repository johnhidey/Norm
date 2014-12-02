using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CECity.Enterprise.Data;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;


namespace CECity.Enterprise.DataConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int networkId = 261;

            Database.Using
                .Connection
                    .SetConnectionStringName("Lifetime")
                    .SetErrorCallback((s, e) => { })
                .Command
                    .SetCommandText("COC_GetFolders")
                    .SetErrorCallback((s, e) => { })
                    .AddParameter("CommunityGroupID", networkId)
                .ExecuteNonQuery();

            int id = Database.Using
                .Connection
                    .SetConnectionStringName("Lifetime")
                    .SetErrorCallback((s, e) => { })
                .Command
                    .SetCommandText("COC_GetFolders")
                    .SetErrorCallback((s, e) => { })
                    .AddParameter("CommunityGroupID", networkId)
                .ExecuteScalar<int>();

            //Folder folder = Database.Using
            //    .Connection
            //        .SetConnectionStringName("Lifetime")
            //        .SetErrorCallback((s, e) => { })
            //    .Command
            //        .SetCommandText("COC_GetFolders")
            //        .SetErrorCallback((s, e) => { })
            //        .AddParameter("CommunityGroupID", networkId)
            //    .Execute<Folder>(new FolderMapper());


            IList<IDynamicResult> multipleObjects = Database.Using
                .Connection
                    .SetConnectionStringName("Lifetime")
                    .SetErrorCallback((s, e) => { })
                .Command
                    .SetCommandText("COC_GetMessage")
                    .SetErrorCallback((s, e) => { })
                    .AddParameter("@MessageRecipientID", 4)
                    .AddParameter("@UserID", 15029)
                .Execute(new List<IEntityMap>() {
                                                    new MessageMap(),
                                                    new NetworkMap(),
                                                    new UserMap(),
                                                    new AttachmentMap()
                                                }, true);

            List<Folder> folders = Database.Using
                .Connection
                    .SetConnectionStringName("Lifetime")
                    .SetErrorCallback((s, e) => { })
                .Command
                    .SetCommandText("COC_GetFolders")
                    .SetErrorCallback((s, e) => { })
                    .AddParameter("CommunityGroupID", networkId)
                .Execute<List<Folder>>(new ListMapper<Folder>(new FolderMapper()));

            Message message = Database.Using
                .Connection
                    .SetConnectionStringName("Lifetime")
                    .SetErrorCallback((s, e) => { })
                .Command
                    .SetCommandText("COC_GetMessage")
                    .SetErrorCallback((s, e) => { })
                    .AddParameter("@MessageRecipientID", 4)
                    .AddParameter("@UserID", 15029)
                .Execute<Message>(new MessageMapper());


        }
    }


    #region Entities

    public class Folder
    {
        public int Id { get; set; }
		public string Name { get; set; }
        public int MessageCount { get; set; }
        public int NetworkId { get; set; }
    }

    #endregion

    #region Mapping

    public class FolderMapper : IEntityMap<Folder>
    {
        public Folder Map(IDataRecord record)
        {
            Folder folder = new Folder();

            folder.Id = record.GetInt32("COC_MessageFolderId");
            folder.Name = record.GetString("MessageFolder");
            folder.NetworkId = record.GetInt32("CommunityGroupId");
            folder.MessageCount = record.GetInt32("TotalMessageCount");

            return folder;
        }

        object IEntityMap.Map(IDataRecord record)
        {
            return Map(record);
        }
    }

    public class Message {
        public int MessageID { get; set; }
        public string Subject { get; set; }
        public List<Network> Networks { get; set; }
        public List<User> AttentionUsers { get; set; }
        public List<Attachment> Attachments { get; set; }
    }

    public class MessageMap : IEntityMap<Message>
    {
        public int MessageID { get; set; }
        public string Subject { get; set; }
        public List<Network> Networks { get; set; }
        public List<User> AttentionUsers { get; set; }
        public List<Attachment> Attachments { get; set; }

        public Message Map(IDataRecord record)
        {
            Message folder = new Message();
            return folder;
        }

        object IEntityMap.Map(IDataRecord record)
        {
            return Map(record);
        }
    }

    public class Network
    {
        public int NetworkId { get; set; }
        public string NetworkName { get; set; }
    }

    public class NetworkMap : IEntityMap<Network>
    {
        public int NetworkId { get; set; }
        public string NetworkName { get; set; }

        public Network Map(IDataRecord record)
        {
            return new Network();
        }

        object IEntityMap.Map(IDataRecord record)
        {
            return Map(record);
        }
    }

    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
    }

    public class UserMap : IEntityMap<User>
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }

        public User Map(IDataRecord record)
        {
            return new User();
        }

        object IEntityMap.Map(IDataRecord record)
        {
            return Map(record);
        }
    }

    public class Attachment
    {
        public int AttachmentID { get; set; }
        public string Display { get; set; }
    }

    public class AttachmentMap : IEntityMap<Attachment>
    {
        public int AttachmentID { get; set; }
        public string Display { get; set; }

        public Attachment Map(IDataRecord record)
        {
            return new Attachment();
        }

        object IEntityMap.Map(IDataRecord record)
        {
            return Map(record);
        }
    }

    public class MessageMapper : IComplexEntityMap<Message>
    {
        public Message Map(DbDataReader record)
        {
            var details = record.Cast<DbDataRecord>().AsEnumerable().ToArray();
            record.NextResult();
            var networks = record.Cast<DbDataRecord>().AsEnumerable().ToArray();
            record.NextResult();
            var attention = record.Cast<DbDataRecord>().AsEnumerable().ToArray();
            record.NextResult();
            var attachments = record.Cast<DbDataRecord>().AsEnumerable().ToArray();

            var message = details.Select(m => new Message()
            {
                MessageID = m.GetInt32("CoC_MessageID"),
                Subject = m.GetString("Subject"),
                Networks = networks.Where(n => n.GetInt32("CoC_MessagEID") == m.GetInt32("CoC_MessageID")).Select(
                    n => new Network()
                    {
                        NetworkId = n.GetInt32("CommunityGroupID"),
                        NetworkName = n.GetString("Name")
                    }
                ).ToList(),
                AttentionUsers = attention.Where(a => a.GetInt32("CoC_MessagEID") == m.GetInt32("CoC_MessageID")).Select(
                    a => new User()
                    {
                        UserID = a.GetInt32("UserID"),
                        FirstName = a.GetString("FirstName")
                    }
                ).ToList(),
                Attachments = attachments.Where(a => a.GetInt32("CoC_MessagEID") == m.GetInt32("CoC_MessageID")).Select(
                    a => new Attachment()
                    {
                        AttachmentID = a.GetInt32("CoC_MessageAttachmentId"),
                        Display = a.GetString("Attachment_Display")
                    }
                ).ToList()
            });

            return message.FirstOrDefault();

        }

        object IComplexEntityMap.Map(DbDataReader record)
        {
            return Map(record);
        }
    }

    #endregion
}
