# CollectionViewNullBindingContext

This sample shows that the data binding inside an ItemTemplate for a CollectionView in .NET MAUI is evaluated way more than it needs to be, specifically 3 times per item or more. 

Even worse, the first time it executes for each item, the BindingContext is null. The BindingContext should never be null on an item in a CollectionView that has an ItemsSource.

I would expect the Binding to only be evaluated once per item, since all the values are set before we even instantiate the view, and never give me a null BindingContext.