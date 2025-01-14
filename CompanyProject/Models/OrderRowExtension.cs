﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject.Models
{
    [MetadataTypeAttribute(typeof(OrderRowMetaData))]
    public partial class OrderRow : IDataErrorInfo
    {
        [IndexerName("MyIndex")] //creato perchè il this crea una proprietà item per la classe che noi però in OrderRow abbiamo già
                                 //quindi con questo attributo sopra cambiamo il nome della proprietà che crea in MyIndex, che poi a noi non interessa
                                 //perchè lo usa solo IDataErrorInfo.
        public string this[string columnName]
        {
            get
            {
                ValidationContext valContext = new ValidationContext(new OrderRowMetaData())
                {
                    MemberName = columnName
                };

                List<ValidationResult> validationResults = new List<ValidationResult>();

                if (Validator.TryValidateProperty(
                        GetType().GetProperty(columnName).GetValue(this),
                        valContext,
                        validationResults))
                {
                    ErrorChecker = false;
                    return "";
                }

                ErrorChecker = true;
                
                return validationResults.First().ErrorMessage;

            }
        }

        private string _error;
        public string Error => _error;
        public bool ErrorChecker;

    }

    public class OrderRowMetaData
    {//grandezze uguali al db
        public int OrderRowId { get; set; }
        public Nullable<int> OrderHeaderId { get; set; }
        public Nullable<int> ItemId { get; set; }
        [Range(0, 1000000, ErrorMessage = "The quantity must be 0 or more")]
        public int Quantity { get; set; }//>=0
        public double UnitPrice { get; set; }
    }
}
