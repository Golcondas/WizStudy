using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace SandwichServices
{
    [ServiceContract(Namespace = "SandwichServices")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class CostService
    {
        //来源 http://www.cnblogs.com/jfzhu/p/4041638.html 如何创建一个AJAX-Enabled WCF Service

        // 要使用 HTTP GET，请添加 [WebGet] 特性。(默认 ResponseFormat 为 WebMessageFormat.Json)
        // 要创建返回 XML 的操作，
        //     请添加 [WebGet(ResponseFormat=WebMessageFormat.Xml)]，
        //     并在操作正文中包括以下行:
        //         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";
        [OperationContract]
        public void DoWork()
        {
            // 在此处添加操作实现
            return;
        }
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Test/CostOfSandwiches", ResponseFormat = WebMessageFormat.Json)]
        [DescriptionAttribute("好接口")]
        // 在此处添加更多操作并使用 [OperationContract] 标记它们
        public double CostOfSandwiches(int quantity) 
        {
            try
            {

            }
            catch (Exception)
            {
                
                throw;
            }

            return 1.25 * quantity;
        }
    }
}
