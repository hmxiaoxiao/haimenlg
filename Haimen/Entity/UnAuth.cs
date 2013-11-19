using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;

namespace Haimen.Entity
{
    [Table("t_unauth")]
    public class UnAuth : MEntityFunction<UnAuth>
    {
        [Field("code")]
        public string Code { get; set; }

        [Field("company_id")]
        public long CompanyID { get; set; }

        private Company _company = null;
        public Company Company
        {
            get
            {
                if (CompanyID == 0)
                    return null;
                if (_company == null)
                    _company = Company.CreateByID(CompanyID);
                return _company;
            }
        }

        [Field("compandetail_id")]
        public long CompanyDetailID { get; set; }

        private CompanyDetail _Detail;
        public CompanyDetail CompanyDetail
        {
            get
            {
                if (CompanyDetailID == 0)
                    return null;
                if (_Detail == null)
                    _Detail = CompanyDetail.CreateByID(CompanyDetailID);
                return _Detail;
            }
        }


        [Field("input")]
        public string Input { get; set; }

        [Field("output")]
        public string Output { get; set; }

        [Field("money")]
        public decimal Money { get; set; }

        [Field("memo")]
        public string Memo { get; set; }

        public override bool Verify()
        {
            Error_Info.Clear();

            if (string.IsNullOrEmpty(Code))
                Error_Info.Add(new KeyValuePair<string, string>("Code", "凭证号不能为空!"));

            return Error_Info.Count == 0;
        }
    }
}
