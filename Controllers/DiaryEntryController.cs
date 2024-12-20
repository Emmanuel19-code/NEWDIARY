using Microsoft.AspNetCore.Mvc;
using NewDiary.Data;
using NewDiary.Models;

namespace NewDiary.Controllers
{
    public class DiaryEntryController : Controller 
    {
        private readonly ApplicationDbContext _db;
        public DiaryEntryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index(){
            List<DiaryEntryData> DiaryEntriesList = _db.DiaryEntries.ToList();
            return View(DiaryEntriesList);
        }

        public IActionResult EnterDiaryData(){
            return View();
        }

        [HttpPost]
        public IActionResult EnterDiaryData(DiaryEntryData obj){
            if(obj != null && obj.Title.Length < 3){
                ModelState.AddModelError("Title", "Title too short");
            } 
            if(ModelState.IsValid){
                _db.DiaryEntries.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult EditDiary(int? id){
            if(id == null || id == 0){
                return NotFound();
            }
            DiaryEntryData? diaryEntry = _db.DiaryEntries.Find(id);
            if(diaryEntry == null){
                return NotFound();
            }
            return View(diaryEntry);
        }

        [HttpPost]
        public IActionResult EditDiary(DiaryEntryData obj){ 
            if(obj != null && obj.Title.Length < 3){
                ModelState.AddModelError("Title", "Title too short");
            } 
            if(ModelState.IsValid){
                _db.DiaryEntries.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpGet]
        public IActionResult DeleteDiary(int? id){
            if(id == null || id == 0){
                return BadRequest();
            }
            DiaryEntryData? diaryEntry = _db.DiaryEntries.Find(id); // Corrected line
            if(diaryEntry == null){
                return NotFound();
            }
            return View(diaryEntry);
        }

        [HttpPost]
        public IActionResult DeleteDiary(DiaryEntryData obj){
             if(obj == null){
                return NotFound();
             }
             _db.DiaryEntries.Remove(obj);
             _db.SaveChanges();
              return  RedirectToAction("Index");
        }
    }
}
