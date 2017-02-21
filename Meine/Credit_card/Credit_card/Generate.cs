using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Credit_card
{
    public class Generate
    {
        public static string[] AMEX_PREFIX_LIST = new[] { "34", "37" };


        public static string[] DINERS_PREFIX_LIST = new[]
                                                        {
                                                            "300",
                                                            "301", "302", "303", "36", "38"
                                                        };


        public static string[] DISCOVER_PREFIX_LIST = new[] { "6011" };


        public static string[] ENROUTE_PREFIX_LIST = new[]
                                                        {
                                                            "2014",
                                                            "2149"
                                                        };


        public static string[] JCB_15_PREFIX_LIST = new[]
                                                        {
                                                            "2100",
                                                            "1800"
                                                        };


        public static string[] JCB_16_PREFIX_LIST = new[]
                                                        {
                                                            "3088",
                                                            "3096", "3112", "3158", "3337", "3528"
                                                        };


        public static string[] MASTERCARD_PREFIX_LIST = new[]
                                                            {
                                                                "51",
                                                                "52", "53", "54", "55"
                                                            };


        public static string[] VISA_PREFIX_LIST = new[]
                                                    {
                                                        "4539",
                                                        "4556", "4916", "4532", "4929", "40240071", "4485", "4716", "4"
                                                    };


        public static string[] VOYAGER_PREFIX_LIST = new[] { "8699" };

        /*
      'prefix' is the start of the  CC number as a string, any number
        private of digits   'length' is the length of the CC number to generate.
     * Typically 13 or  16
        */
        private static string CreateFakeCreditCardNumber(string prefix, int length)
        {
            string ccnumber = prefix;

            while (ccnumber.Length < (length - 1))
            {
                double rnd = (new Random().NextDouble() * 1.0f - 0f);

                ccnumber += Math.Floor(rnd * 10);

                //sleep so we get a different seed

                Thread.Sleep(20);
            }


            // reverse number and convert to int
            var reversedCCnumberstring = ccnumber.ToCharArray().Reverse();

            var reversedCCnumberList = reversedCCnumberstring.Select(c => Convert.ToInt32(c.ToString()));

            // calculate sum

            int sum = 0;
            int pos = 0;
            int[] reversedCCnumber = reversedCCnumberList.ToArray();

            while (pos < length - 1)
            {
                int odd = reversedCCnumber[pos] * 2;

                if (odd > 9)
                    odd -= 9;

                sum += odd;

                if (pos != (length - 2))
                    sum += reversedCCnumber[pos + 1];

                pos += 2;
            }

            // calculate check digit
            int checkdigit =
                Convert.ToInt32((Math.Floor((decimal)sum / 10) + 1) * 10 - sum) % 10;

            ccnumber += checkdigit;

            return ccnumber;
        }

        public static string GenerateCardNumber(string[] prefixList, int length)
        {
            int randomPrefix = new Random().Next(0, prefixList.Length - 1);

            if (randomPrefix > 1)
            {
                randomPrefix--;
            }

            string ccnumber = prefixList[randomPrefix];

            return CreateFakeCreditCardNumber(ccnumber, length);
        }
        
        public bool Valódi(string creditCardNumber)
        {
            try
            {
                double sum = 0;
                for (int i = 0; i <= creditCardNumber.Length-1; i++)
                {
                    double akt = char.GetNumericValue(creditCardNumber,i) ;
                    if ((i % 2)==0)
                    {
                        if (akt>4)
                        {
                            sum = sum + 2 * akt - 9;
                        }
                        else
                        {
                            sum = sum + 2 * akt;
                        }
                    }
                    else
                    {
                        sum = sum + akt;
                    }
                }
                if ((sum % 10) == 0)
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
            return false;
            
            
        }
    }
}

