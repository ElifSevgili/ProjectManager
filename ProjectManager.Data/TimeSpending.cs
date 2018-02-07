using ProjectManager.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManager.Data
{
    public class TimeSpending:BaseEntity
    {
        public TimeSpending()
        {
            CreateDate = DateTime.Now;
        }
       
        [Required]
        [Display(Name = "Ad")]
        public string Name { get; set; }
        [Display(Name = "Proje")]
        public int ProjectId { get; set; }
        [ForeignKey("ProjectId")]
        [Display(Name = "Proje")]
        public Project Project { get; set; }
        [Display(Name = "Görev")]
        public string TaskId { get; set; }
        [ForeignKey("TaskId")]
        [Display(Name = "Görev")]
        public Task Task { get; set; }
       
        
        [Display(Name = "Harcanan Zaman (dk)")]
        public int TimeSpent { get; set; }
        [Display(Name = "Durum")]
        public Status Status { get; set; }
      
     }
}