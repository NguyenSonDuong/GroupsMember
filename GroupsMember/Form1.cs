using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookAPI.model;
using System.Threading;

namespace GroupsMember
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void AddCookie(String cookie, RestRequest request)
        {
            String[] cookies = cookie.Split(';');
            foreach(String item in cookies)
            {
                String[] cookieItem = item.Trim().Split('=');
                if (cookieItem.Length > 1)
                {
                    request.AddCookie(cookieItem[0], cookieItem[1]);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Thread trh = new Thread(() =>
            {
                GetMember("");
            });
            trh.IsBackground = true;
            trh.Start();
        }
        int dem = 0;
        public void GetMember(String cursor)
        {
            var client = new RestClient("https://www.facebook.com/api/graphql");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            AddCookie("fr=1kBct58bPO5na4geO.AWXD_7Q_KFRGIXcv4nBOIXzweck.Bgh5e8.uR.AAA.0.0.BgiPmQ.AWVbTkshOds; sb=vJeHYJasHf3bKiNa5DCh40MF; wd=1903x966; datr=vJeHYMGy3juy1W3v9ufNRonU; _fbp=fb.1.1619588906476.1215958157; locale=vi_VN; c_user=100010625562840; xs=20%3Ane5vEjc3l4F7YA%3A2%3A1619589521%3A9766%3A2631; spin=r.1003705778_b.trunk_t.1619681397_s.1_v.2_", request);
            client.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36";
            request.AddHeader("Accept", "*/*");
            request.AddHeader("Referer", "https://www.facebook.com/groups/2908365305855309/members");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("av", "100010625562840");
            request.AddParameter("__user", "100010625562840");
            request.AddParameter("__a", "1");
            request.AddParameter("dpr", "1");
            request.AddParameter("fb_dtsg", "AQGwGbZr7Qf2ruY:AQEG8cYMs5NaEO8");
            request.AddParameter("jazoest", "22456");
            request.AddParameter("fb_api_caller_class", "RelayModern");
            request.AddParameter("fb_api_req_friendly_name", "useGroupsCometMemberSearchResultsRefetchQuery");
            String vari = "{\"count\":20,\"cursor\":\"" + cursor + "\",\"groupID\":\"364997627165697\",\"query\":\"\",\"scale\":1,\"id\":\"364997627165697\"}";
            request.AddParameter("variables", vari);
            request.AddParameter("server_timestamps", "true");
            request.AddParameter("doc_id", "4391041100924633");
            IRestResponse response = client.Execute(request);
            if(response != null && !String.IsNullOrEmpty(response.Content))
            {
                FacebookAPI.model.GroupsMember groupsMember = JsonConvert.DeserializeObject<FacebookAPI.model.GroupsMember>(response.Content);
                if(groupsMember.data.node.search_results.page_info != null && groupsMember.data.node.search_results.page_info.has_next_page)
                {
                    
                    foreach(Edge item in groupsMember.data.node.search_results.edges)
                    {
                        dem++;
                        richTextBox1.Invoke(new MethodInvoker(() =>
                        {
                            richTextBox1.AppendText(dem+" : "+item.node.id + " | " + item.node.name + "\n");
                            richTextBox1.ScrollToCaret();
                        }));
                    }
                    Thread.Sleep(1000);
                    GetMember(groupsMember.data.node.search_results.page_info.end_cursor);
                }
                else
                {
                    richTextBox1.Invoke(new MethodInvoker(() =>
                    {
                        richTextBox1.SelectionColor = Color.Green;
                        richTextBox1.AppendText("Đã hết\n");
                        richTextBox1.ScrollToCaret();
                    }));
                }
            }
            else
            {
                richTextBox1.Invoke(new MethodInvoker(() =>
                {
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.AppendText("LỖI-----\n");
                    richTextBox1.ScrollToCaret();
                }));
            }
        }
    }
}
