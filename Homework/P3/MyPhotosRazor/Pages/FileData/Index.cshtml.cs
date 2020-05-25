using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyPhotosRazor.Pages.FileData
{
    public class IndexModel : PageModel
    {
        ServiceFresh.InterfaceWCFClient client = new ServiceFresh.InterfaceWCFClient();
        public List<Models.FileDataDTO> FileDatas { get; set; }
        public IndexModel() { FileDatas = new List<Models.FileDataDTO>(); }
        public async Task OnGetAsync(string id)
        {
            if (id == null) return; // RedirectToPage("../File/Index");

            string x = id != null ? id : "";


            List<ServiceFresh.Data> datas = await client.GetDatasAsync();
            List<ServiceFresh.FileData> result = await client.GetFileDatasByFileIdAsync(new Guid(x)); 
            foreach (var filedata in result)
            {
                Models.FileDataDTO dto = new Models.FileDataDTO(filedata);
                dto.DataName = datas.Find(item => item.DataId == filedata.DataId).Label;
                FileDatas.Add(dto);
            }
        }
    }

}