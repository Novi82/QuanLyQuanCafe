using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQuanCafe.Common;
using System.ComponentModel;

namespace QLQuanCafe.DTO
{
     public delegate string ValidateProperty(string propertyName);
     public class ValidateDataSchemaBase : BindableBase, IDataErrorInfo
     {
         private bool _canValidate;
         public bool CanValidate
         {
             get { return _canValidate; }
             set { _canValidate = value; }
         }

         #region IDataErrorInfo Members

         public string Error
         {
             get { return string.Empty; }
         }

         public string this[string collumnName]
         {
             get
             {
                 if (this.CanValidate)
                     return this.Validate(collumnName);

                 return string.Empty;
             }
         }

         #endregion


         #region Validate Section

         public event ValidateProperty OnValidateProperty;

         public string Validate(string propertyName)
         {
             if (this.OnValidateProperty != null)
                 return OnValidateProperty(propertyName);

             return string.Empty;
         }

         #endregion
     }
}
