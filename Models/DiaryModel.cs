using System.ComponentModel.DataAnnotations;


namespace NewDiary.Models
{
public class DiaryEntryData 
{
    
    public int Id {get;set;}
    [Required(ErrorMessage="Please provide the Title")]
    //[StringLength(100,MinimumLength=3,ErrorMessage="The Title Should have a lenght between 3 and 100")]
    public string Title {get;set;} = string.Empty;
    [Required(ErrorMessage="Please provide the Content")]
    public string Content {get;set;} = string.Empty;   
    public DateTime CreatedDate {get;set;} = DateTime.MinValue; 

}
}
