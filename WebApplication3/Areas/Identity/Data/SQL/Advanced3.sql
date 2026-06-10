SELECT StockID, ItemName, StockTag
FROM Stock as st, Item as it
WHERE st.ItemID = it.ItemID