Imports simpi.CoreData
Imports simpi.MarketInstrument

Module ModMasterSecurities
    Friend dtInstrumentUser As New DataTable
    Friend dtInstrumentCcy As New DataTable
    Friend dtInstrumentPortfolio As New DataTable

    Friend Function GetInstrumentUser() As DataTable
        If dtInstrumentUser IsNot Nothing AndAlso dtInstrumentUser.Rows.Count > 0 Then Return dtInstrumentUser Else Return GetInstrumentUserUpdate()
    End Function

    Friend Function GetInstrumentUserUpdate() As DataTable
        Dim objPos As New PositionSecurities
        Dim objSecurities As New MarketInstrument
        objPos.UserAccess = objAccess
        objSecurities.UserAccess = objAccess
        dtInstrumentUser = objSecurities.Search(objPos.SecuritiesUniverse)
        Return dtInstrumentUser
    End Function

    Friend Function GetInstrumentCcy(ByVal CcyID As Integer) As DataTable
        Dim objSecurities As New MarketInstrument
        objSecurities.UserAccess = objAccess
        dtInstrumentCcy = objSecurities.Search(0, "", 0, 0, 0, CcyID, 0)
        Return dtInstrumentCcy
    End Function

    Friend Function GetInstrumentPortfolio(ByVal objPortfolio As simpi.MasterPortfolio.MasterPortfolio) As DataTable
        Dim objPos As New PositionSecurities
        Dim objSecurities As New MarketInstrument
        objPos.UserAccess = objAccess
        objSecurities.UserAccess = objAccess
        dtInstrumentPortfolio = objSecurities.Search(objPos.SecuritiesUniverse(objPortfolio))
        Return dtInstrumentPortfolio
    End Function

End Module
