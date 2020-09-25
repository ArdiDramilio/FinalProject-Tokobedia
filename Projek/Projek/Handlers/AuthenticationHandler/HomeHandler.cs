using Projek.Model;
using Projek.Repository.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Handlers
{
    public class HomeHandler
    {
        public static MsUser FetchDataForHome(String ID)
        {
            MsUser user = Repository.RepositoryMsUser.GetUserByID(ID);
            return user;
        }
        public static List<DetailProduct> FetchDataRandom()
        {
            Random randd = new Random();
            int alldata = Repository.RepositoryMsProduct.CountData();
            int availabledata = Repository.RepositoryMsProduct.CountAvailableData();
            if (availabledata > 5)
            {
                List<int> RandNum = new List<int>();
                for (int i = 0; i < 5; i++)
                {
                    int temp;
                    MsProduct ProductTemp;
                    int stocktemp;
                    do
                    {
                        temp = randd.Next(1, alldata + 1);
                        String ProductID = "PD" + temp.ToString();
                        ProductTemp = Repository.RepositoryMsProduct.SearchProductByID(ProductID);
                        stocktemp = int.Parse(ProductTemp.ProductStock.ToString());

                    } while (RandNum.Contains(temp) || stocktemp == 0);
                    RandNum.Add(temp);
                }
                String ran1 = "PD" + RandNum[0];
                String ran2 = "PD" + RandNum[1];
                String ran3 = "PD" + RandNum[2];
                String ran4 = "PD" + RandNum[3];
                String ran5 = "PD" + RandNum[4];
                return Repository.RepositoryMsProduct.FetchDataRandom(ran1, ran2, ran3, ran4, ran5);
            }
            else
            {
                return Repository.RepositoryMsProduct.FetchDataProduct();
            }
        }
           
    }
}