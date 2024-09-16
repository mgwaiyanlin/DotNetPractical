using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DotNetPractical.RestAPIwithNLayers.Features.MyanmarProverbs;

[Route("api/[controller]")]
[ApiController]
public class MyanmarProverbController : ControllerBase
{
    private async Task<Tbl_MmproverbsRoot> GetDataAsync()
    {
        // --------- The way of fetching hosted API ---------
        //HttpClient client = new HttpClient();
        //var response = await client.GetAsync("https://raw.githubusercontent.com/burma-project-ideas/myanmar-proverbs/main/MyanmarProverbs.json");

        //if (response.IsSuccessStatusCode)
        //{
        //    string jsonString = await response.Content.ReadAsStringAsync();
        //    var model = JsonConvert.DeserializeObject<Tbl_MmproverbsRoot>(jsonString);

        //    return model!;
        //}


        // --------- The way of fetching local json file ---------
        string jsonString = await System.IO.File.ReadAllTextAsync("MyanmarProverbs.json");
        var model = JsonConvert.DeserializeObject<Tbl_MmproverbsRoot>(jsonString);

        return model!;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var model = await GetDataAsync();

        return Ok(model);
    }

    [HttpGet("show_proverb_heads/based_on_mmcharacter/{character}")]
    public async Task<IActionResult> GetProverbTitles(string character)
    {
        var model = await GetDataAsync();
        var characterInput = model.Tbl_MMProverbsTitle.FirstOrDefault(x => x.TitleName == character);

        if (characterInput == null) { return NotFound("Data Not Found!"); }

        var listOfProverbs = model.Tbl_MMProverbs.Where(x => characterInput.TitleId == x.TitleId).Select( x => new Tbl_MmproverbsHead
        {
            TitleId = x.TitleId,
            ProverbId = x.ProverbId,
            ProverbName = x.ProverbName,
        });
        
        return Ok(listOfProverbs);
    }

    [HttpGet("proverb_in_details/{character}/{proverbId}")]
    public async Task<IActionResult> GetProverbInDetail(string character, int proverbId)
    {
        var model = await GetDataAsync();
        var characterInput = model.Tbl_MMProverbsTitle.FirstOrDefault(x => x.TitleName == character);
        if (characterInput == null) { return NotFound("Data Not Found!"); }
        var proberInDetail = model.Tbl_MMProverbs.FirstOrDefault(x => x.TitleId == characterInput.TitleId && x.ProverbId == proverbId);

        return Ok(proberInDetail);
    }

}

public class Tbl_MmproverbsRoot
{
    public Tbl_Mmproverbstitle[]? Tbl_MMProverbsTitle { get; set; }
    public Tbl_MmproverbsInDetails[]? Tbl_MMProverbs { get; set; }
}

public class Tbl_Mmproverbstitle
{
    public int TitleId { get; set; }
    public string? TitleName { get; set; }
}

public class Tbl_MmproverbsHead
{
    public int TitleId { get; set; }
    public int ProverbId { get; set; }
    public string? ProverbName { get; set; }
}

public class Tbl_MmproverbsInDetails
{
    public int TitleId { get; set; }
    public int ProverbId { get; set; }
    public string? ProverbName { get; set; }
    public string? ProverbDesp { get; set; }
}

