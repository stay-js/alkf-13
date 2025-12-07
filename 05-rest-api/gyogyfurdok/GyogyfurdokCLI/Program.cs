using GyogyfurdokLib;

var api = new ApiClient();

var allBaths = await api.GetAsync<IEnumerable<Bath>>("/furdo");

#region 3.a
Console.WriteLine("3.a feladat: Összesen " +
    allBaths.Count(x => x.City == "Budapest") +
    " gyógyfürdő található Budapesten.");
#endregion
