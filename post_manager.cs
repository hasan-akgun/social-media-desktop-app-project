using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace social_media
{
    public class Post
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string created_at { get; set; }
        public string Text { get; set; }
        public bool isShown { get; set; } = false;

    }
    internal class PostManager
    {
        public List<Post> Posts { get; private set; }

        public PostManager()
        {
        }

        public async Task LoadPostsAsync()
        {
            Posts = await FetchPostsAsync();
        }

        private static async Task<List<Post>> FetchPostsAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("https://oasisgamequizium.shop/OOPProject/Posts/GetAllPosts.php");
                var responseString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Bağlandı");
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse>(responseString);
                    if (apiResponse.Status == "success")
                    {
                        return apiResponse.Data;                       
                    }
                    else
                    {
                        MessageBox.Show("API çağrısı başarısız: ");
                        return new List<Post>();
                    }
                }
                else
                {
                    MessageBox.Show($"API çağrısı başarısız oldu. Durum kodu: {response.StatusCode}. Yanıt: {responseString}");
                    return new List<Post>();
                }
            }
        }
    }

    public class ApiResponse
    {
        public string Status { get; set; }
        public List<Post> Data { get; set; }
    }
}

