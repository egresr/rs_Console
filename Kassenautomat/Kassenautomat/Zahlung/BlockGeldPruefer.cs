namespace Kassenautomat.Zahlung
{
    static class BlockGeldPruefer
    {
        static int[] euroBanknotenReferenz = new int[] { 5, 10, 20, 50, 100, 200, 500 };
        static int[] euroMuenzenReferenz = new int[] { 1, 2, 5, 10, 20, 50, 100, 200 };        

        static public bool PreufeBanknote(Banknote banknote)
        {
            bool status = false;
            foreach (var item in euroBanknotenReferenz)
            {
                if (banknote.NennWert == item)
                    status = true;
            }

            return status;
        }

        static public bool PreufeMuenze(Muenze muenze)
        {
            bool status = false;
            foreach (var item in euroMuenzenReferenz)
            {
                if (muenze.NennWert == item)
                    status = true;
            }

            return status;
        }
    }
}
