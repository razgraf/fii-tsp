using Client.ServiceReferencePC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
*/

            ServiceReferencePC.PostCommentClient client = new ServiceReferencePC.PostCommentClient();
            List<Post> posts = client.GetPosts().ToList();

            foreach (Post p in posts)
                Console.WriteLine(p.ToString());

        }
    }
}
