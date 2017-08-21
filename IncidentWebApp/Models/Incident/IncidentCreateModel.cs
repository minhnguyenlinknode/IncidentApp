using BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IncidentWebApp.Models.Incident
{
    public class IncidentCreateModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Need incident name")]
        [Display(Name = "Incident Name")]
        public string IncidentName { get; set; }

        [Required(ErrorMessage = "Also need the created date")]
        [DataType(DataType.Date)]
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "Require number of people")]
        [Range(0, 100)]
        [Display(Name = "Number of People")]
        public int NumberPeople { get; set; }

        [Display(Name = "Is Urgent?")]
        public bool IsUrgent { get; set; }

        [Display(Name = "Incident Type")]
        public int SelectedIncidentType { get; set; }

        public List<SelectListItem> IncidentTypeList { get; set; }

        public IncidentCreateModel()
        {
            this.CreatedDate = DateTime.Now;
        }

        public IncidentCreateModel(BusinessObject.Incident incident)
        {
            this.Id = incident.Id;
            this.IncidentName = incident.IncidentName;
            this.CreatedDate = incident.CreatedDate;
            this.NumberPeople = incident.NumberPeople;
            this.IsUrgent = incident.IsUrgent;
            this.SelectedIncidentType = incident.IncidentType ?? 1;
        }

        public BusinessObject.Incident GetIncidentObj()
        {
            return new BusinessObject.Incident()
            {
                Id = this.Id,
                IncidentName = this.IncidentName,
                CreatedDate = this.CreatedDate,
                NumberPeople = this.NumberPeople,
                IsUrgent = this.IsUrgent,
                IncidentType = this.SelectedIncidentType
            };
        }
    }
}