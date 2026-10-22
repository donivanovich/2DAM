report 50100 "Radio Shows Report"
{
    UsageCategory = ReportsAndAnalysis;         // Determina donde aparece el informe al buscarlo en BC
    ApplicationArea = All;                      // 
    DefaultLayout = Word;                       // Aplicacion que voy a usar
    WordLayout = 'RadioShows.docx';             // Nombre del archivo word que contiene el diseño del archivo 


    dataset
    {
        dataitem(DataItemName; "Radio Show")
        {
            // columna(nombreColumnaEndatos; campoDeLaTabla)
            column("No"; "No."){}
            column("RadioShowType"; "Radio Show Type"){}
            column("Name"; "Name"){}
            column("RunTime"; "Run Time"){}
            column("HostNo"; "Host No"){}
            column("HostName"; "Host Name"){}
            column("AverageListeners" ; "Average Listeners"){}
            column("Audienceshare"; "Audience share"){}
            column("AdvertisingRevenue"; "Advertising Revenue"){}
            column("RoyaltyCost"; "Royalty Cost"){}
        }
    }
}