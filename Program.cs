using System;

namespace structassignmentpedroarzuaga
{
    struct WizardCurrency
    {
        public int galleons;
        public int sickles;
        public int knuts;

        public void WizardCurrencly(int newGalleon, int newSickle, int newknut)
        {
            galleons = newGalleon;
            sickles = newSickle;
            knuts = newknut;
            WizardCurrency myMoney = new WizardCurrency();
            myMoney.galleons = 5;
            myMoney.sickles = 12;
            myMoney.knuts = 20;
        }
        void Add(int Galleons, int Sickles, int Knuts)
        {
            Galleons = Galleons + galleons;
            Sickles = Sickles + sickles;
            Knuts = Knuts + knuts;
            while (sickles > 29)
                while (knuts > 17)
                {
                    Knuts -= 18;
                    Sickles++;
                }
            {
                Sickles -= 30;
                Galleons++;
            }

        }



    }






}

