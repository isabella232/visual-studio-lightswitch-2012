﻿'You can use and redistribute the code from this book (and sample application) for non-commercial and 
'most commercial purposes as long as you acknowledge the source and authorship. 
'You should note the source of the code in any documentation as well as in the program code itself (as a comment). 
'The acknowledgment should include author, title, publisher, and ISBN. 
'An example of such an acknowledgment would be "Derived from Listing 2-10, LightSwitch 2012 by Tim Leung, published by Apress, ISBN 9781430250715".

Imports System.Transactions
Imports System.Text

Namespace LightSwitchApplication

    Public Class ApplicationDataService


        'Listing 4-5. Retrieving Original Values in Code

        'Private Sub Issues_Updated(entity As Issue)                                  

        '    Dim issueHistory As IssueStatusChange =
        '    Me.DataWorkspace.ApplicationData.IssueStatusChanges.AddNew()

        '    issueHistory.OldStatus =
        '        entity.Details.Properties.IssueStatus.OriginalValue                   

        '    issueHistory.NewStatus = entity.IssueStatus
        '    issueHistory.Issue = entity
        '    issueHistory.ChangeDate = DateTime.UtcNow                                 

        'End Sub


        'Listing 4-7. Creating Your Own Transaction Scope

        'Dim transaction As TransactionScope

        'Private Sub SaveChanges_Executing()

        '    Dim transactionOptions = New TransactionOptions()
        '    transactionOptions.IsolationLevel = IsolationLevel.ReadCommitted

        '    'Create an audit record as part of the transaction                      
        '    Me.transaction = New TransactionScope(
        '       TransactionScopeOption.Required, transactionOptions)

        '    Dim auditDesc As StringBuilder =
        '       New StringBuilder("Changes " + DateTime.Now.ToString() + " :")
        '    For Each changedEntity In
        '       Me.DataWorkspace.ApplicationData.Details.GetChanges()

        '        auditDesc.AppendLine(changedEntity.Details.Entity.ToString())
        '    Next

        '    Using dataworkspace2 = Me.Application.CreateDataWorkspace()
        '        Dim auditRecord = dataworkspace2.AuditDataSource.AuditDetails.AddNew
        '        auditRecord.AuditDesc = auditDesc.ToString()
        '        dataworkspace2.AuditDataSource.SaveChanges()
        '    End Using

        'End Sub

        'Private Sub SaveChanges_Executed()
        '    'Commit the transaction                                                 
        '    Me.transaction.Complete()
        '    Me.transaction.Dispose()
        'End Sub

        'Private Sub SaveChanges_ExecuteFailed(exception As System.Exception)
        '    'Rollback the transaction on an error                                   
        '    Me.transaction.Dispose()
        'End Sub


        Private Sub Issues_Validate(entity As Issue, results As EntitySetValidationResultsBuilder)

            'Listing 5-6. Validating the Counts of Child Items 
            If entity.IssueDocuments.Count > 10 Then
                results.AddEntityError(
                   "Issues can only contain a maximum of 10 documents")
            End If

            'Listing 5-10. Validating Deletions on the Server 
            ' Check for validation errors for deletions
            If entity.Details.EntityState = EntityState.Deleted Then
                If entity.IssueResponses.Where(
                   Function(s) s.AwaitingClient).Any() Then
                    results.AddEntityError(
                       "Cannot delete issues with responses awaiting client.")
                End If

            End If


        End Sub

        'Listing 5-10. Validating Deletions on the Server 
        Private Sub Issues_Deleting(entity As Issue)

            ' Check for validation errors for deletions
            If entity.Details.ValidationResults.Errors.Any Then
                Throw New ValidationException(Nothing,
                   Nothing, entity.Details.ValidationResults)
            End If

            ' Cascade delete children because delete rule is Restricted
            For Each resp In entity.IssueResponses
                resp.Delete()
            Next

        End Sub

        'Listing 6-7. Filtering by Child Items   
        Private Sub EngineersWithOutstandingIssues_PreprocessQuery(ByRef query As System.Linq.IQueryable(Of LightSwitchApplication.Engineer))
            query = query.Where(Function(engItem) engItem.Issues.Where(
              Function(issueItem) issueItem.IssueStatus.StatusDescription = "Open").Any())

        End Sub

        'Listing 6-9. Returning All Issues with Related Issue Document Records
        Private Sub IssuesWithAttachments_PreprocessQuery(ByRef query As System.Linq.IQueryable(Of LightSwitchApplication.Issue))
            query = query.Where(Function(issueItem) issueItem.IssueDocuments.Any())
        End Sub

        'Listing 6-11. Returning Issue Records Without Any Issue Responses   
        Private Sub IssuesWithNoResponse_PreprocessQuery(ByRef query As System.Linq.IQueryable(Of LightSwitchApplication.Issue))
            query = query.Where(Function(issueItem) Not issueItem.IssueResponses.Any())
        End Sub

        'Listing 6-12. Filtering by Month and Year Parameter Values   
        Private Sub IssuesByMonthAndYear_PreprocessQuery(IssueMonth As System.Nullable(Of Integer), IssueYear As System.Nullable(Of Integer), ByRef query As System.Linq.IQueryable(Of LightSwitchApplication.Issue))
            If (IssueMonth.HasValue And IssueYear.HasValue) Then
                query = query.Where(
                    Function(item) item.CreateDateTime.Month = IssueMonth.Value AndAlso
                        item.CreateDateTime.Year = IssueYear.Value)
            End If
        End Sub

        'Listing 6-13. Query to Return Issues with the Highest Feedback
        Private Sub IssuesWithHighestFeedback_PreprocessQuery(ByRef query As System.Linq.IQueryable(Of LightSwitchApplication.Issue))
            query = query.OrderByDescending(
    Function(issueItem) issueItem.IssueFeedbacks.Average(
        Function(feedback) feedback.OverallRating)).Take(5)

        End Sub
    End Class

End Namespace
