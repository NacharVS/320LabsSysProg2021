using Raspisanie.Shared.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Raspisanie.Server.DataAccess
{
    public class PaspisanieDataAccessLayer
    {
        RaspDBContext db = new RaspDBContext();
        //To Get all employees details
        public List<Lesson> GetAllLessons(){
            try{
                return db.LessonRecord.Find(_ => true).ToList();
            }            
            catch            
            {                
                throw;            
            }        
        }        
        //To Add new employee record
        public void AddLesson(Lesson lesson)        
        {            
            try            
            {                
                db.LessonRecord.InsertOne(lesson);            
            }            
            catch            
            {                
                throw;            
            }        
        }        
        //Get the details of a particular employee
        public Lesson GetLessonData(string id)        
        {            
            try            
            {                
                FilterDefinition<Lesson> filterLessonData = Builders<Lesson>.Filter.Eq("Id", id);
                return db.LessonRecord.Find(filterLessonData).FirstOrDefault();           
            }            
            catch            
            {                
                throw;            
            }        
        }        
        //To Update the records of a particular employee
        public void UpdateLesson(Lesson lesson)        
        {            
            try            
            {                
                db.LessonRecord.ReplaceOne(filter: g => g.Id == lesson.Id, replacement: lesson);            
            }            
            catch            
            {                
                throw;            
            }        
        }        
        //To Delete the record of a particular employee
        public void DeleteLesson(string id)        
        {            
            try            
            {                
                FilterDefinition<Lesson> lessonData = Builders<Lesson>.Filter.Eq("Id", id);                
                db.LessonRecord.DeleteOne(lessonData);            
            }            
            catch            
            {                
                throw;            
            }        
        }        
        // To get the list of Cities
        public List<Day> GetCityData()        
        {            
            try            
            {                
                return db.DayRecord.Find(_ => true).ToList();            
            }            
            catch            
            {                
                throw;            
            }        
        }
    }
}
