using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyPhotosRazor.Pages.Data
{
    public class IndexModel : PageModel
    {
        ServiceFresh.InterfaceWCFClient client = new ServiceFresh.InterfaceWCFClient();
        public List<Models.DataDTO> Datas { get; set; }
        public IndexModel() { Datas = new List<Models.DataDTO>(); }
        public async Task OnGetAsync()
        {

            List<ServiceFresh.Data> result = await client.GetDatasAsync(); 
            foreach (var data in result)
            {
                Models.DataDTO dto = new Models.DataDTO(data);
                Datas.Add(dto);
            }
        }
    }

}