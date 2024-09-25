namespace L03_Objektorientering.Opg3_2
{
    class MedarbejderListe<TKey>
    {
        private readonly Dictionary<TKey, IHarAdresse> _collection = new Dictionary<TKey, IHarAdresse>();

        public void AddElement(TKey k, IHarAdresse m)
        {
            if (!_collection.ContainsKey(k))
                _collection.Add(k, m);
            else
                throw new Exception("Nøglen er optaget!");
        }

        public IHarAdresse GetElement(TKey k)
        {
            if (_collection.ContainsKey(k))
                return _collection[k];
            else
                return null;
        }

        public int Size() { 
            return _collection.Count;
        }

      
    }
}
