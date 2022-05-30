using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web; //=> HttpPostedFileBase

namespace Common
{
    public class ImageUploader
    {
       
		/*
        0=> "dosya boş"
        1=> "bu görsel zaten eklenmiş"
        2=> "uymayan format"
        3=> "ekleme başarılı"
         */
        public static string UploadImage(string imagePath, HttpPostedFileBase file)
        {
            string fileName = "";
            if (file != null)
            {
                var uniqName = Guid.NewGuid();
                imagePath.Replace("~", "");

                var fileArray = file.FileName.Split('.'); //=> split ayırıcı (.)verdik nokta gördüğü yerde ayıracak.
                string extension = fileArray[fileArray.Length - 1].ToLower();//uzantıyı yakaladık..
                fileName = uniqName + "." + extension;

                if (extension == "png" || extension == "jpg" || extension == "jpeg" || extension == "gif")
                {
                    try
                    {
                        var filePath = HttpContext.Current.Server.MapPath(imagePath + fileName);
                        file.SaveAs(filePath);
                        return fileName;
                    }
                    catch (Exception ex)
                    {
                        return ex.Message;
                    }
                }
                else
                {
                    return "2";
                }
            }
            else
            {
                return "0";
            }
        }
        #region PhotoUpload II.Yol
        //public class FileExtensionAttribute : ValidationAttribute
        //{
        //    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        //    {
        //        IFormFile file = value as IFormFile;
        //        if (file != null)
        //        {
        //            var extension = Path.GetExtension(file.FileName);
        //            string[] extensions = { "jpg", "png", "jpeg" };
        //            bool result = extensions.Any(x => extension.EndsWith(x));
        //            if (!result)
        //            {
        //                return new ValidationResult(GetErrorMessage());
        //            }
        //        }
        //        return ValidationResult.Success;
        //    }

        //    private string GetErrorMessage()
        //    {
        //        return "Allowed extension are jpg png jpeg";
        //    }
        //} 
        #endregion
    }
}
