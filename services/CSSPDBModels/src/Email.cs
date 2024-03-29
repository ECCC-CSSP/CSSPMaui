﻿namespace CSSPDBModels;

public partial class Email : LastUpdate
{
    [Key]
    public int EmailID { get; set; }
    [CSSPEnumType]
    public DBCommandEnum DBCommand { get; set; } = DBCommandEnum.Original;
    [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "7")]
    [CSSPForeignKey(TableName = "TVItems", FieldName = "TVItemID")]
    public int EmailTVItemID { get; set; }
    [CSSPMaxLength(255)]
    [DataType(DataType.EmailAddress)]
    public string EmailAddress { get; set; } = string.Empty;
    [CSSPEnumType]
    public EmailTypeEnum EmailType { get; set; } = EmailTypeEnum.Work;

    public Email() : base()
    {

    }
}

