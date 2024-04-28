using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Record.Firebase
{
    internal class FirestoreHelper
    {
        static string fireconfig = @"
            {
              ""type"": ""service_account"",
              ""project_id"": ""studentrecorddb"",
              ""private_key_id"": ""bbaccc339c9717b8f5e086703542b5b1f599367e"",
              ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvgIBADANBgkqhkiG9w0BAQEFAASCBKgwggSkAgEAAoIBAQDTyjow5NxHoIiy\n96ajFzMg1/2BvPRdMNzt+Yxb020XtL+krJwYjIwf+VVNhb5vMmb29SHCObtlj1VF\nIeH3YmcRuSC5YJpLqPzNrmjLs8BUPZ7dWxvKLWLfXW4sk+RjlAtGYmGTB+vq0/sN\nwVAOOxAzfRVsZdSohdfPax4vGA9fXxh5rkiDAx5/RprJ8v/3ty+2umKphJsm6M2+\nTqZ4berUycz8Qk+dt8Ha0bOep7dgFSFhRNN1eC5eb4kDIkBjC7A8U71HbzrWwodI\n9v/1VKl0QvGHGHAYfj1Qiy2PFy/QD2NZOPRePsY+u2J/E7NbBedzARCyafW2Dlor\nVxLlXIyPAgMBAAECggEAMOv1PicXdRoxiXmoTeMFhfAumGHv5njrh7MNx4ZSnFe9\nrwnKMueAVMBxAmvC/geb/i7IogdY8NBHp6T4f/8EhPUJCJk2ewSphM9lWKyIYE0t\nnb82b6DFRohb80MkThY79oGyPVbmmYNm6hn95pOhHeumX7g0A8uK+tgpDELYBjTT\nB6Ljt/qrmXATMTPD0et9Bi4rT8/puUxXwJiyPL/lKVLZ72itCxRhuVWDTVtsX1tk\n4nHYr1tFgYvH8GVi7339ZhMs52pLK5+PVZijJeXiOHX2+z/CrgqmpLS91alo9fwQ\nlZe9IUK5ArtnCbQCyLix7SMOrEft7Z0HCXThmqUfhQKBgQD1VD2KmZkM2kgXqpNN\nghBjs4ICXge+m0kXIEcFylzCosYTMKHCmqXHfnZgjM/hMHc734YAKUxjEq0U8Kyl\nnBUUqGXUyLz0M8gNCU0VH/k61z+naTJYmi47Ryp366PCVr3wD6RYzq+AOkgY2hTZ\nvs3kIojuBxI4T+GyjCXpDCzuEwKBgQDdAIatYCDLVlCk+QV++Ow5WmqEGEMPi0JZ\nd3mDsBGUztex4HwCC6DTEu+I1JkLQ25xBXl5HmUfhZsLLnurfKJlKJ9RHmm4SQTc\nfwcoZ3At5j2hvld+tcyAB+q9sq7iCjlaB2VL9FlQ3cKx55JI4KfzHeyK0MW/a1Dk\nOJJoC3uHFQKBgAvfu+rNbF724a5jjyWdOfXZZl1+95j+Ixd/dHCPTtYM0tFy9SFa\nItP5Bvm9VwJrOhonw3CWjx/sc3wj+fc6CrspO2SFIsAfEXuwC48OMR3r9STBLrKj\nI8GyvBd5zD9Hu4G3ABlcR5pJN9wcEg5H8ecs1LvQk80t8JqXte4FrNcJAoGBALH2\niHz4ma/j89DFDp3uiRquKnPwrZ/IvkcZJGrcz2uLHLoKURG8l2chKm5+9DbTuA2f\nIPBdf4Tgq7dXWRMArCzVh2VlHjDd6+I7EGKC2Ry8+QhUJFTOxLyco3TafGVdYk2T\nAwkk3P93dB6aoXu6HMRzZlVqRLMeEeeVfp/2DyT5AoGBALX3SbMl56fmL3eCa0xu\n94uia3VGHjWa7lErJvET3RiWotV9rDdrv3pIibCDGpKxrRAaTgR5vhC2SE4AXU3t\nuU+f3+v71AQ685BVz7K9WIh8XvHEf8RZ5ROu+zwhQCGKPxVi2aqmHYQDSs8h3kOM\n9igcrDf8guOFejp2bdBHuNYX\n-----END PRIVATE KEY-----\n"",
              ""client_email"": ""firebase-adminsdk-q5kqp@studentrecorddb.iam.gserviceaccount.com"",
              ""client_id"": ""108373405273174804915"",
              ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
              ""token_uri"": ""https://oauth2.googleapis.com/token"",
              ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
              ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-q5kqp%40studentrecorddb.iam.gserviceaccount.com"",
              ""universe_domain"": ""googleapis.com""
            }
        ";

        static string filepath = "";
        public static FirestoreDb? database { get; set; }

        public static void SetEnvironmentVariable()
        {
            filepath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName())) + ".json";
            File.WriteAllText(filepath, fireconfig);
            File.SetAttributes(filepath, FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
            database = FirestoreDb.Create("studentrecorddb");
            File.Delete(filepath);
        }
    }
}
