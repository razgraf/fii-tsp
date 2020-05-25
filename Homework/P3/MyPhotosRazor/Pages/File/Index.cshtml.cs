using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyPhotosRazor.Pages.File
{
    public class IndexModel : PageModel
    {
        ServiceFresh.InterfaceWCFClient client = new ServiceFresh.InterfaceWCFClient();
        
        public List<Models.FileDTO> Files { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Types { get; set; }
        [BindProperty(SupportsGet = true)]
        public string FileType { get; set; }


        public IndexModel() { Files = new List<Models.FileDTO>(); }
        public async Task OnGetAsync()
        {

            List<ServiceFresh.File> result = await client.GetFilesAsync(); 
            foreach (var file in result)
            {
                Models.FileDTO dto = new Models.FileDTO(file);
                Files.Add(dto);
              
            }

            if (!string.IsNullOrEmpty(SearchString))
            {
                Files.Clear();

                List<ServiceFresh.Data> datas = await client.GetDatasAsync();
                List<ServiceFresh.FileData> filedatas = await client.GetFileDatasAsync();

                ServiceFresh.Data data = datas.Find(item => item.Label.Equals(SearchString));
                if (data != null)
                {
                    Files = new List<Models.FileDTO>();
                    foreach (ServiceFresh.File file in result)
                    {
                        ServiceFresh.FileData fd = filedatas.Find(item => item.DataId == data.DataId && item.FileId == file.FileId);
                        if (fd != null)
                        {
                            Models.FileDTO dto = new Models.FileDTO(file);
                            Files.Add(dto);
                        }

                    }
                }

            }
        }
    }

}