SELECT IssueID, FirstName, LastName, SubjectName, [Period], Reason, DateIssued 
FROM Issue AS it, Student AS st, [Subject] AS su
WHERE it.StudentID = st.StudentID AND it.SubjectID = su.SubjectID AND st.[Year] BETWEEN 9 AND 10