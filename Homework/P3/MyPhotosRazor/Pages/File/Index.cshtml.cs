using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyPhotosRazor.Pages.File
{
    public class IndexModel : PageModel
    {
        ServiceFresh.InterfaceWCFClient client = new ServiceFresh.InterfaceWCFClient();
        public List<Models.FileDTO> Files { get; set; }
        public IndexModel() { Files = new List<Models.FileDTO>(); }
        public async Task OnGetAsync()
        {

            List<ServiceFresh.File> result = await client.GetFilesAsync(); 
            foreach (var file in result)
            {
                Models.FileDTO dto = new Models.FileDTO(file);
                Files.Add(dto);
            }
        }
    }

}