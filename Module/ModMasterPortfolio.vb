Imports simpi.MasterPortfolio
Imports simpi.ParameterPortfolio
Imports simpi.ParameterFA
Imports simpi.Codeset

Module ModMasterPortfolio
    Friend dtPortfolioMaster As New DataTable
    Friend dtPortfolioBankAccount As New DataTable
    Friend dtPortfolioCodeset As New DataTable
    Friend dtPortfolioExternalID As New DataTable

    Friend dtParameterPortfolioCodeset As New DataTable
    Friend dtParameterPortfolioPricing As New DataTable
    Friend dtParameterPortfolioFee As New DataTable

    Friend dtParameterPortfolioStatus As New DataTable
    Friend dtParameterPortfolioAsset As New DataTable
    Friend dtParameterPortfolioType As New DataTable

    Friend Function GetPortfolioMaster() As DataTable
        If dtPortfolioMaster IsNot Nothing AndAlso dtPortfolioMaster.Rows.Count > 0 Then Return dtPortfolioMaster Else Return GetPortfolioMasterUpdate()
    End Function

    Friend Function GetPortfolioMasterUpdate() As DataTable
        Dim objPortfolio As New MasterPortfolio
        objPortfolio.UserAccess = objAccess
        dtPortfolioMaster = objPortfolio.Search("")
        Return dtPortfolioMaster
    End Function

    Friend Function GetPortfolioBankAccount() As DataTable
        If dtPortfolioBankAccount IsNot Nothing AndAlso dtPortfolioBankAccount.Rows.Count > 0 Then Return dtPortfolioBankAccount Else Return GetPortfolioBankAccountUpdate()
    End Function

    Friend Function GetPortfolioBankAccountUpdate() As DataTable
        Dim objAccount As New PortfolioBankAccount
        objAccount.UserAccess = objAccess
        dtPortfolioBankAccount = objAccount.SearchAccount(objMasterSimpi, "")
        Return dtPortfolioBankAccount
    End Function

    Friend Function GetPortfolioCodeset() As DataTable
        If dtPortfolioCodeset IsNot Nothing AndAlso dtPortfolioCodeset.Rows.Count > 0 Then Return dtPortfolioCodeset Else Return GetPortfolioCodetsetUpdate()
    End Function

    Friend Function GetPortfolioCodetsetUpdate() As DataTable
        Dim objCodeset As New PortfolioCodeset
        objCodeset.UserAccess = objAccess
        dtPortfolioCodeset = objCodeset.Search(objMasterSimpi, "")
        Return dtPortfolioCodeset
    End Function

    Friend Function GetPortfolioExternalID() As DataTable
        If dtPortfolioExternalID IsNot Nothing AndAlso dtPortfolioExternalID.Rows.Count > 0 Then Return dtPortfolioExternalID Else Return GetPortfolioExternalIDUpdate()
    End Function

    Friend Function GetPortfolioExternalIDUpdate() As DataTable
        Dim objPortfolio As New MasterPortfolio
        objPortfolio.UserAccess = objAccess
        dtPortfolioExternalID = objPortfolio.ExternalID_Search(objMasterSimpi)
        Return dtPortfolioExternalID
    End Function

    Friend Function GetParameterPortfolioFee() As DataTable
        If dtParameterPortfolioFee IsNot Nothing AndAlso dtParameterPortfolioFee.Rows.Count > 0 Then Return dtParameterPortfolioFee Else Return GetParameterPortfolioFeeUpdate()
    End Function

    Friend Function GetParameterPortfolioFeeUpdate() As DataTable
        Dim objFee As New ParameterCharges
        objFee.UserAccess = objAccess
        dtParameterPortfolioFee = objFee.Search("")
        Return dtParameterPortfolioFee
    End Function

    Friend Function GetParameterPortfolioCodesetField() As DataTable
        If dtParameterPortfolioCodeset IsNot Nothing AndAlso dtParameterPortfolioCodeset.Rows.Count > 0 Then Return dtParameterPortfolioCodeset Else Return GetParameterPortfolioCodesetFieldUpdate()
    End Function

    Friend Function GetParameterPortfolioCodesetFieldUpdate() As DataTable
        Dim objCodeset As New CodesetPortfolioField
        objCodeset.UserAccess = objAccess
        dtParameterPortfolioCodeset = objCodeset.Search("")
        Return dtParameterPortfolioCodeset
    End Function

    Friend Function GetParameterPortfolioPricing() As DataTable
        If dtParameterPortfolioPricing IsNot Nothing AndAlso dtParameterPortfolioPricing.Rows.Count > 0 Then Return dtParameterPortfolioPricing Else Return GetParameterPortfolioPricingUpdate()
    End Function

    Friend Function GetParameterPortfolioPricingUpdate() As DataTable
        Dim objPricing As New ParameterPortfolioPricing
        objPricing.UserAccess = objAccess
        dtParameterPortfolioPricing = objPricing.Search("")
        Return dtParameterPortfolioPricing
    End Function

    Friend Function GetParameterPortfolioStatus() As DataTable
        If dtParameterPortfolioStatus IsNot Nothing AndAlso dtParameterPortfolioStatus.Rows.Count > 0 Then Return dtParameterPortfolioStatus Else Return GetParameterPortfolioStatusUpdate()
    End Function

    Friend Function GetParameterPortfolioStatusUpdate() As DataTable
        Dim objStatus As New ParameterPortfolioStatus
        objStatus.UserAccess = objAccess
        dtParameterPortfolioStatus = objStatus.Search("")
        Return dtParameterPortfolioStatus
    End Function

    Friend Function GetParameterPortfolioType() As DataTable
        If dtParameterPortfolioType IsNot Nothing AndAlso dtParameterPortfolioType.Rows.Count > 0 Then Return dtParameterPortfolioType Else Return GetParameterPortfolioTypeUpdate()
    End Function

    Friend Function GetParameterPortfolioTypeUpdate() As DataTable
        Dim objType As New ParameterPortfolioType
        objType.UserAccess = objAccess
        dtParameterPortfolioType = objType.Search("")
        Return dtParameterPortfolioType
    End Function

    Friend Function GetParameterPortfolioAssetType() As DataTable
        If dtParameterPortfolioAsset IsNot Nothing AndAlso dtParameterPortfolioAsset.Rows.Count > 0 Then Return dtParameterPortfolioAsset Else Return GetParameterPortfolioAssetTypeUpdate()
    End Function

    Friend Function GetParameterPortfolioAssetTypeUpdate() As DataTable
        Dim objAsset As New ParameterPortfolioAssetType
        objAsset.UserAccess = objAccess
        dtParameterPortfolioAsset = objAsset.Search("")
        Return dtParameterPortfolioAsset
    End Function

End Module
