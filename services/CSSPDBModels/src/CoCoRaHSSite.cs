﻿namespace CSSPDBModels;

public partial class CoCoRaHSSite : LastUpdate
{
    [Key]
    public int CoCoRaHSSiteID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPMaxLength(100)]
    public string StationNumber { get; set; } = string.Empty;
    [CSSPMaxLength(100)]
    public string StationName { get; set; } = string.Empty;
    [CSSPRange(-90.0D, 90.0D)]
    public double Latitude { get; set; }
    [CSSPRange(-180.0D, 180.0D)]
    public double Longitude { get; set; }

    public CoCoRaHSSite() : base()
    {

    }
}


