interface ISearchable
{
    List<Product> SearchByCriteria(Func<Product, bool> criteria);
}