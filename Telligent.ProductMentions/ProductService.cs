using System;
using System.Collections.Generic;
using System.Linq;
using Mentions;

namespace Telligent.ProductMentions
{
    public class ProductService
    {
        #region Sample Data

        public static IList<ProductContent> SampleData = new List<ProductContent>
        {
            new ProductContent
            {
                ContentId = new Guid("c5e0a50b5be74c57b55ac8f84f71c7dc"),
                Title = "Karcher K3 Follow-Me 1800 PSI 1.3 GPM Electric Power Pressure Washer with 4-Wheels",
                Body =
                    "Follows While You Clean Everywhere! 1800PSI Electric Pressure Washer, UP to 35X the Pressure of a Garden Hose, Uses up to 80% Less Water than a Garden Hose, 100% Quality Tested - Performance - Innovation - Power - Reliability - Kärcher!",
                Url =
                    "http://www.amazon.com/Karcher-Follow-Me-Electric-Pressure-4-Wheels/dp/B00J00J0WK/ref=sr_1_4?m=ATVPDKIKX0DER&s=lawn-garden&ie=UTF8&qid=1462867973&sr=1-4&refinements=p_6%3AATVPDKIKX0DER%2Cp_72%3A2661619011"
            },
            new ProductContent
            {
                ContentId = new Guid("ab62f638693a443d89215d93fa650186"),
                Title = "BLACK+DECKER GH900 14-Inch String Trimmer and Edger, 6.5 Amp",
                Body =
                    @"The Black & Decker GH900 14"" 6.5 Amp Corded String Trimmer and Edger is built with a lightweight ergonomic design with adjustable height and pivoting handle positions which give maximum comfort and control. The 6.5 amp motor and high torque transmission provide maximum performance when trimming through the toughest weeds, grass and overgrowth and the Power Drive Transmission prevents bogging down in heavy grass and weeds. This unit features AFS automatic feed system which ensures continual work without bumping or having to stop to feed the spool. It is designed with 2-in-1 easy conversion wheeled edging- just rotate to convert from trimmer to edger and the Smart Edge mode gives more control and accuracy in edge mode for straighter and cleaner edging results.Commonly used for trimming grass in hard to reach areas where mowers can not cut and for maintenance edging along hard surfaces.Includes: (1) GH900 Trimmer / Hedger, (1) AF - 100 spool, (1) Auxiliary Handle and(1) Guard.",
                Url =
                    "http://www.amazon.com/BLACK-DECKER-GH900-14-Inch-Trimmer/dp/B00HH4K6RE/ref=sr_1_3?m=ATVPDKIKX0DER&s=lawn-garden&ie=UTF8&qid=1462867973&sr=1-3&refinements=p_6%3AATVPDKIKX0DER%2Cp_72%3A2661619011"
            },
            new ProductContent
            {
                ContentId = new Guid("53bb6348e7f4493eba4c5b0252e500df"),
                Title = "GreenWorks 21212 4Amp 13-Inch Corded String Trimmer",
                Body =
                    "The GreenWorks products that you purchase have a ZERO carbon footprint. We'll say that again - our entire product line will never release an ounce of carbon emission into the air. 4 Year Warranty - Double The Industry Standard. When looking for lawn tools, we know you're thinking about quality. You're looking for something that will get the job done and get you back to your weekend. That's why GreenWorks backs every tool with a full four-year warranty - we know our products will perform at the highest level and always be reliable. GreenWorks high quality products are manufactured to last. That's why we back every product with a warranty that's twice the industry standard. We'll provide all the power you need without polluting the air or forcing you to keep hauling your gas can to the nearest station (especially in the middle of a mow). No more tune-ups or maintenance. No more emissions. Fifty-four million Americans mow their lawns every weekend, according to the EPA, using 800 million gallons of gas each year. Along the way, homeowners spill more than 17 million gallons of gas while refueling. That's equivalent to the 1989 Exxon Valdez disaster. It's time to move beyond clumsy, harmful gas-powered mowers. It's time for GreenWorks to be your lawn tools for life. Power cord not included.",
                Url =
                    "http://www.amazon.com/GreenWorks-21212-13-Inch-Corded-Trimmer/dp/B0030GEXUO/ref=sr_1_2?m=ATVPDKIKX0DER&s=lawn-garden&ie=UTF8&qid=1462867973&sr=1-2&refinements=p_6%3AATVPDKIKX0DER%2Cp_72%3A2661619011"
            },
            new ProductContent
            {
                ContentId = new Guid("d5c185ce3c954d1289f87a319082deed"),
                Title =
                    "WORX WG156 Li-Ion Cordless Grass Trimmer/Edger with 2 20-volt Batteries and Manual Handle, 10-Inch",
                Body =
                    "The WORX WG156 is a compact and light weight cords trimmer/edger. The WG156 comes with two 20-Volt Max Lithium batteries that provide long life, no memory effect and no self discharge, while being light weight. The trimmer easily converts into an edger and vise-versa in seconds to allow you to keep working. The Edger function features in-line wheels to make edging a breeze. There is a 100% automatic single line feed for best cutting performance and no need for bumping to extend the line. The trimmer has an adjustable spacer guard that helps protect flowers and ornamental landscaping. The two included batteries provide you with twice the run time so you can get the job done without interruption. The WG156 is also very ergonomic with a telescoping pole for height adjustment and a pivoting handle for comfort and control.",
                Url =
                    "http://www.amazon.com/WG156-Cordless-Trimmer-20-volt-Batteries/dp/B00J4VZYRA/ref=sr_1_12?m=ATVPDKIKX0DER&s=lawn-garden&ie=UTF8&qid=1462867973&sr=1-12&refinements=p_6%3AATVPDKIKX0DER%2Cp_72%3A2661619011"
            },
            new ProductContent
            {
                ContentId = new Guid("e9441267881543c0a558004c69006b2e"),
                Title = "GreenWorks 25012 12 Amp Corded 18-Inch Lawn Mower",
                Body =
                    "The GreenWorks products that you purchase have a ZERO carbon footprint. We'll say that again - our entire product line will never release an ounce of carbon emission into the air. 4 Year Warranty - Double The Industry Standard. When looking for lawn tools, we know you're thinking about quality. You're looking for something that will get the job done and get you back to your weekend. That's why GreenWorks backs every tool with a full four-year warranty - we know our products will perform at the highest level and always be reliable. GreenWorks high quality products are manufactured to last. That's why we back every product with a warranty that's twice the industry standard. We'll provide all the power you need without polluting the air or forcing you to keep hauling your gas can to the nearest station (especially in the middle of a mow). No more tune-ups or maintenance. No more emissions. Fifty-four million Americans mow their lawns every weekend, according to the EPA, using 800 million gallons of gas each year. Along the way, homeowners spill more than 17 million gallons of gas while refueling. That's equivalent to the 1989 Exxon Valdez disaster. It's time to move beyond clumsy, harmful gas-powered mowers. It's time for GreenWorks to be your lawn tools for life.",
                Url =
                    "http://www.amazon.com/dp/B002ZVOLX4/ref=s9_acsd_bw_wf_a_wfgard_cdl_1?pf_rd_m=ATVPDKIKX0DER&pf_rd_s=merchandised-search-6&pf_rd_r=0CRTP9B8XAG1V0BZ567B&pf_rd_t=101&pf_rd_p=ab92b836-6d03-48dc-9fbf-ad3d853481f4&pf_rd_i=12717570011"
            }
        };

        #endregion

        public static ProductContent Get(Guid contentId)
        {
            return SampleData.FirstOrDefault(x => x.ContentId == contentId);
        }

        public static IEnumerable<ProductContent> FindProduct(string queryText)
        {
            return SampleData.Where(x => x.Title.ToLower().Contains(queryText.ToLower()));
        }
    }
}
