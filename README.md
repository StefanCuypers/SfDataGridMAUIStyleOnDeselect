# SfDataGridMAUIStyleOnDeselect
Illustrates a style issue in Syncfusion SfDataGrid for MAUI

Run the program.
The rows are in a specific style (showing text in Magenta if not in dark mode).
Now select the first row -> it switched to selected style which is ok.
Now select the second row -> first row gets deselected but it does not switch back to the original style.
