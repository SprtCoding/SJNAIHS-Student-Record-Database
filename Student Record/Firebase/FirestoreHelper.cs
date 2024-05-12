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
  ""project_id"": ""sjnaihs-62774"",
  ""private_key_id"": ""ca74b7cb5b4793d8b0f5406a23ceb04150f32d54"",
  ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvgIBADANBgkqhkiG9w0BAQEFAASCBKgwggSkAgEAAoIBAQDZn1NUVu2kCzFn\nzGzTbbcsMQSbWtzvzc/cRHiOVh6PFXJvp9ifTfqfj+FipbXT1kP3XSEzqhq+Dld9\nTf+LiHFSm0SUr9IJ/VWyOE8g8/HDCtddbsISUyZrglfYIGia+xeqtyPbnNI94FjJ\nsw4IrNlLrKuvSXUHGZBw00bY2f5YRYEZ1au0QhbA29fHbDdk22yLj+M6zZXiQEl8\nIq9Nag+v1EHZUgiM3lvSuoaDzqlO4zC0WC1t/I4Pr/YFEKkp/TuuZ72YnYin5ioB\nSu0gbt1m2+tbGnx0It4H/xKlkhDkyg4Ud0s0OmKGtNMds5LRv/SHAx6WBj+UYMW1\nctnte4sPAgMBAAECggEACK8gbzY5GwLIwv9ljufB14waoiwjIHQP/AQgUW91nkrL\nTb/DafdrbYK/9+3aMyOlFfZnWWsU0IoF1CuZ2VKlmnM1AL/vFx1jg9d69yi+Cqmp\nuyas9gph0pqZcKWDAD8XQy6j3HVGE+q+3f9YGRfPiEwtSyC9NyLQhRpaYC8NoC4y\nb/1I/t1v/C5ZgC8TwMsV8Hz7/aJPUoGcRApO9S1JYorqgFmqhWqCmc3KsNTbuyOn\nPtmROzAJrCGMBbClW1FjiXChSJ3WOqlSpRlpbo9xlPTCwkLueVjAO0zdvMnEb4mh\n3I3AIZJtsM09utE44tobpaEYo5pWou/9PZv6szxqRQKBgQDyY3QdQY+OsA3+m57a\numCv30BpScnBXL4Ib6VbiXYvjhQeWYE17viNzGQrkyDDPbRR4I0pFzfC7L2iff8N\nVS95WdikUwCitRMy1IAwK6y5RuTXfnss1MO2thU6jRap7UvqzwOqQY9FH/0tomRW\nhL+IDTHdfN8QwVLLjGbhbM97WwKBgQDl19ZVCRwndXbAY1NQnD7Tyd+SEsyRuv9i\nnCCD0PY/K6gjPEi4lZaKjkCafipoNBPoB07NXQrPxtUyRWzHzs0vnKM/t9LAjFfu\nbbUkw0fimSHAAQLjxyJrgim72oZmV7Qls0diyPR6S8wzMNzjewDAoUODWz5/uv1Y\nvTqQPK8hXQKBgCV6FRj06xJfzDoiq6QcDxkCRr5Ax24bPdKmGIYXsetWZ2vt4NmK\n8mlSQeau3/DwGHJUat8AlQGRgxydqJLSKf30U1fM8Zs2rho82vkXt6QJ/xYGm1rq\nJryYWJ3t9KQfaY6LpYBslI9Wi9nDcwohik+p4pzhUsgPbBLGyZ1vKoFjAoGBALp5\ngcAeEwSEjaMLMsY87dBAga3uqKA3egnUJ6EqgQ7BabmkqE9xteCWBx4Q7HD8h4YB\nn9KIAUSPydrubpIxW1GcoOoKRufHNXQQ+B1qfkD/Al3XtDN/FZLp2Ng7ND2GPHc1\n293uskMiifqiUyQQYIzoiXDiL3PMDs3XQNNTGLdVAoGBAO7Y/cpjkXQU/EbZZMRN\n9QatJ7qJ3iS0CWBn7LYy08RcVRKZA8jJdavPh6YhZCdfa3O1FQ4VCpwxsqBW6rQf\n1ADwRiwWZy6Wshet4QInN2PkNSuIjTaAkQIGuHnmyIzlSKuL2weh4jtW6YBnscuz\nH4lzL7PoAsQDy8UJyyLdu7kA\n-----END PRIVATE KEY-----\n"",
  ""client_email"": ""firebase-adminsdk-v8bsp@sjnaihs-62774.iam.gserviceaccount.com"",
  ""client_id"": ""102199939381079415195"",
  ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
  ""token_uri"": ""https://oauth2.googleapis.com/token"",
  ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
  ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-v8bsp%40sjnaihs-62774.iam.gserviceaccount.com"",
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
            database = FirestoreDb.Create("sjnaihs-62774");
            File.Delete(filepath);
        }
    }
}
