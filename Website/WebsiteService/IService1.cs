using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WebsiteDomain;

namespace WebsiteService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void AddGebruiker(User u);

        [OperationContract]
        IEnumerable<SUser> GetUsers();


        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class SUser
    {
        public SUser(WebsiteDomain.User u)
        {
            Id = u.Id;
            Naam = u.Naam;
            Email = u.Email;
            Tele = u.Tele;
        }

        [DataMember]
        public int Id { get; set; }

        [Required]
        [Range(0, 50)]
        [DataMember]
        public string Naam { get; set; }

        [Required]
        [Range(0, 50)]
        [DataMember]
        public string Email   { get; set; }

        [Required]
        [RegularExpression(@"(^\+[0 - 9]{2}|^\+[0-9]{2}\(0\)|^\(\+[0-9]{2}\)\(0\)|^00[0-9]{2}|^0)([0-9]{9}$|[0-9\-\s]{10}$)", ErrorMessage = "Invalid string")]
        [DataMember]
        public string Tele { get; set; }

        internal WebsiteDomain.User toPoco()
        {
            return new WebsiteDomain.User()
            {
                Id = this.Id,
                Naam = this.Naam,
                Email = this.Email,
                Tele = this.Tele,
            };
        }
    }


}
