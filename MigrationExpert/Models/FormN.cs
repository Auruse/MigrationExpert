using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MigrationExpert.Models
{
    public partial class FormN
    {
        [Display(Name = "Фамилия/ Surname")]
        [StringLength(35, ErrorMessage = "Не боее 35 символов/ Do not enter more than 35 characters")]
        public string Surname { get; set; }

        [Display(Name = "Имя Отчество/ First Name Middle Name")]
        [StringLength(35, ErrorMessage = "Не боее 35 символов/ Do not enter more than 35 characters")]
        public string Name { get; set; }   
        
        public Gender YourGender { get; set; }

        public enum Gender
        {
            [Display(Name = "Мужской/ Male")]
            male,
            [Display(Name = "Женский/ Female")]
            female
        }

        [Display(Name = "Гражданство/ Citizenship")]
        [StringLength(34, ErrorMessage = "Не более 34 символов/ Do not enter more than 34 characters")]
        public string Citizenship { get; set; }

        [Display(Name = "Дата рождения/ Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Место рождения (государство)/ Country of Birth")]
        public string CountryOfBirth { get; set; }

        [Display(Name = "Город рождения/ City of Birth")]
        public string CityOfBirth { get; set; }

        [Display(Name = "Документ, удостоверяющий личность/ Passport or Other Document")]
        [StringLength(11, ErrorMessage = "Не более 11 символов/ Do not enter more than 11 characters")]
        public string PersonalDocumentType { get; set; }

        [Display(Name = "Документ, удостоверяющий личность(серия)/ Passport or Other Document (Series)")]
        [StringLength(4, ErrorMessage = "Не более 4 символов/ Do not enter more than 4 characters")]
        public string PersonalDocumentSeries { get; set; }

        [Display(Name = "Документ, удостоверяющий личность(номер)/ Passport or Other Document (Number)")]
        [StringLength(9, ErrorMessage = "Не более 9 символов/Do not enter more than 9 characters")]
        public string PersonalDocumentNumber { get; set; }

        [Display(Name = "Документ, удостоверяющий личность: дата выдачи)/ Passport or Other Document: Date of Issue)")]
        public DateTime PersonalDocumentDateOfIssue { get; set; }

        [Display(Name = "Документ, удостоверяющий личность: выдан до/ Passport or Other Document:expiration date")]
        public DateTime PersonalDocumentDateOfExpiration { get; set; }

        public Visa YourVisa { get; set; }

        public enum Visa {
            [Display(Name = "Виза/ Visa")]
            visa,
            [Display(Name = "Вид на жительство/ Residence Permission")]
            residence,
            [Display(Name = "Временное проживание/ Temporary Residence")]
            tempResidence
        }
        
        [Display(Name = "Вид и реквизиты документа, подтверждающего право на пребывание(проживание) в РФ")]
        public string RegDocumentType { get; set; }

        [Display(Name = "серия")]
        public string RegDocumentSeries { get; set; }

        [Display(Name = "номер")]
        public string RegDocumentNumber { get; set; }

        [Display(Name = "дата выдачи")]
        public DateTime RegDocumentDateOfIssue { get; set; }

        [Display(Name = "выдан до")]
        public DateTime RegDocumentDateOfExpiration { get; set; }

        public VisitPurpose YourVisitPurpose { get; set; }

        public enum VisitPurpose
        {
            [Display(Name = "Cлужебная/ Government Service")]
            gov,
            [Display(Name = "Туризм/ Tourism")]
            tourism,
            [Display(Name = "Деловая/ Business")]
            business,             
            [Display(Name = "Учебная/ Study")]
            study,
            [Display(Name = "Работа/ Work")]
            work,
            [Display(Name = "Частная/ Private")]
            privateP,             
            [Display(Name = "Транзит/ Transit")]
            transit,
            [Display(Name = "Гуманитарная/ Humanitarian")]
            humanitarian,
            [Display(Name = "Другая/ Other")]
            other
        }
        [Display(Name = "Профессия/ Profession")]
        public string Profession { get; set; }

        [Display(Name = "Дата прибытия/ Arrival Date")]
        public DateTime ArrivalDate { get; set; }

        [Display(Name = "Дата отъезда/ Departure Date")]
        public DateTime DepartureDate { get; set; }

        [Display(Name = "Серия миграционной карты/ Magration Card Series")]
        public string MigrationCardSeries { get; set; }

        [Display(Name = "Номер миграционной карты/ Magration Card Number")]
        public string MigrationCardNumber { get; set; }

        [Display(Name = "Область, край, республика/ Region or Republic")]
        [StringLength(32, ErrorMessage = "<32 символов/ less than 32 characters")]
        public string ArrivalRegion { get; set; }

        [Display(Name = "Район/ Area or District")]
        [StringLength(34, ErrorMessage = "<34 символов/ less than 34 characters")]
        public string ArrivalArea { get; set; }

        [Display(Name = "Город или др. населенный пункт/ City etc.")]
        [StringLength(32, ErrorMessage = "<32 символов/ less than 32 characters")]
        public string ArrivalCity { get; set; }

        [Display(Name = "Улица/Street")]
        [StringLength(34, ErrorMessage = "<34 символов/ less than 34 characters")]
        public string ArrivalStreet { get; set; }

        [Display(Name = "Дом,участок,владение/ House, land, ownership")]
        [StringLength(31, ErrorMessage = "<31 символов/ less than 31 characters")]
        public string ArrivalHouse { get; set; }

        [Display(Name = "Дом №/ House №")]
        [StringLength(4, ErrorMessage = "<4 символов/ less than 4 characters")]
        public string ArrivalHouseNumber { get; set; }

        [Display(Name = "Корпус №/ Housing №")]
        [StringLength(4, ErrorMessage = "<4 символов/ less than 4 characters")]
        public string ArrivalHousingNumber { get; set; }

        [Display(Name = "Строени №/ Building №")]
        [StringLength(4, ErrorMessage = "<4 символов/ less than 4 characters")]
        public string ArrivalBuildingNumber { get; set; }

        [Display(Name = "Квартира, комната, офис/ Flat, room, office")]
        [StringLength(31, ErrorMessage = "<31 символов/ less than 31 characters")]
        public string ArrivalRoomType { get; set; }

        [Display(Name = "Номер квартиры, комнаты, офиса/ Flat, room, office №")]
        [StringLength(5, ErrorMessage = "<5 символов/ less than 5 characters")]
        public string ArrivalRoomNumber { get; set; }
    }
}