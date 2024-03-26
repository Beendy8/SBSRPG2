using System.Collections.Generic;

public class RefreshingLoader<T> : Loader<T>
{
    public void DisableViews()
    {
        foreach (var view in _views)
            view.SetActive(false);
    }
    public void RefreshData(List<T> data)
    {
        DisableViews();
        LoadData(data);
    }
}
