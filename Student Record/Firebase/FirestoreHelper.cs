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
                ""private_key_id"": ""8a6cf35227e0cdb51ba74078a73d4c2219e69c49"",
                ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQCdxofwhZa+86YL\neWyN+6ub4nvdBBBRWtH39XnrHukZJNw5PpeV8kTcImypZDK9VoGk55MnZK8cjL2i\nndQDWX9Ki7+++Ab1crNfdFCeWWkw//mJng577gdS84/R6avEeTwmiQ11nbcrWQ3y\nw7gCbM0IdrfvVCBHb/s87m00eYVSRjttPv/pBg7FGKIGKqMwjzRTQCld27+hO0ha\nKC1N1Zh3GYhNFXVqdKvZ0kWKd7/dx9/BDv2zbUoX9eAcqihbu/y0qzZ3gMxPKneP\n/IUH74eLngmZk4IhO7po6An3wkMnmXCBt0MkM0x+6b48gz6bDbomGlTMK3u4+8cx\n6k3DdfBxAgMBAAECggEACpOd1qMzRnxm4StepOtTcbvDuek6fs8BIbI0Xhf7Cv3M\nQDol8fNaZ7dsZAlHgtHNwb7pv8uhbDSIceJKrX7OaFzombtexrgjC38XTcYzUF7t\n3NUvpgyAM9tdWiEOrA5vLdYk2ixHHyzKdpUQPM62X/Q1bbciAtKgRlFlbg3Ha4sW\ny3wFcTAg+X+lvkWmqS8lA08kMWID0NtXeAhVKeUhuDjM/U+m2EIPUbo+CUPq36Mb\n8Kb7KmX2J99S+q/cfqlilAHNPkfx8Q7jAzbZPebTQFzr9zmZqMgnGPVtKFWEQlie\noSflqDdLLoLM7dbNZq3sIJomnnAe0Cr4DDNlW1dKwQKBgQDLork1kupxns1P+HWh\noUN9ti9+fLLVDE1dNpESV23XpinXS3zzaPigmvslGeB+ctjD/+RPRX30mLyGrNsg\nB3+gxtrY+Isf+fh34rjjL4BYV/znPg7IE+GftPgdHQwAD4yu+NQ4E8CxgwKYvR4Z\nJl9LBRr2AaEIAx6qe35YlwzSfQKBgQDGWNkt3nIxmsxV+1Q5La9r4oOa6/xn466U\nUG5TAU3Tdh8DjI1PloaOozT+hDYNi18+px/kgFw6Wk+i+RU8x8/TprPHYydiT2XQ\n8DSIeUGC2N+UotPYSp/NaSph/cBT4jwXl+PPxwy05/m/cubwTgeKVHQImETX6w6+\n6EFyQYFkBQKBgGR7uG6yP1Ovq9pBXTJTlC0tQERnHgu5FVfgvDdTwxT9nnnpew/V\nhZIix7joCvn6i/IzjCJ9xQh0cdr24u3sJVNdrNIR2vz9aVknHFqmrutpB5fH7J1Y\nCia3sxMSqUBCbAZPLNE7FgPCBP7/myGH6M/pBgPMi/ybJX+0joUCjEY1AoGAcco7\nHkOFw8uI+rLrSLpa70vOMKy962QFnfTetiQDYBNeC40w7L3wiBg9qN50nCSfCbSb\naV3yi0+QbHD1rB79rfDvJq5Nw+rFAK8tlDXsTYLaEc2wN1/oedGhjQIkunsJ+ocb\nHPKW6ZpD/3+N2cMKNGPrBZtFs5GYrhFUqpXGA3kCgYEAu/eNDKMkiI7rQepb/uDz\nzFtcAQb9ep3oqUjQnxaqKeHLpR+qFc7UXXIq/pmR1M8/hNO3Dty9gEhL+OZPrKID\nO9rX73EkEupo429PKyhVBlRyMz9WeUldllvhvUPJaCYlnJCrrY4iOZN5siY03ver\nZeBDiYGBQbch50nbOVJ5LO8=\n-----END PRIVATE KEY-----\n"",
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

        public static void SetEnviroonmentVariable()
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
