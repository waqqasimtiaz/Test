Imports system.Data
Imports System.Data.SqlClient

Public Class MasterEmployeesInfo


    Dim _Emp_code As Integer
    Dim _Emp_Id As String
    Dim _Company_Employee_Flag As String
    Dim _Emp_sex_code As String
    Dim _Emp_marital_status As String
    Dim _Salutation_Code As Integer
    Dim _Emp_name As String
    Dim _Emp_Father_name As String
    Dim _Emp_appointment_date As Date
    Dim _Emp_Confirm_date As Date
    Dim _Emp_Current_address_line1 As String
    Dim _Emp_Current_address_line2 As String
    Dim _Emp_Permanant_address_line1 As String
    Dim _Emp_Permanant_address_line2 As String
    Dim _Emp_address_line1 As String
    Dim _Emp_address_line2 As String
    Dim _Address_City_Code As Integer
    Dim _Emp_home_tel1 As String
    Dim _Emp_home_tel2 As String
    Dim _Emp_office_tel1 As String
    Dim _Emp_office_tel2 As String
    Dim _Emp_mobile_No As String
    Dim _Official_Mobile_No As String
    Dim _Emp_email As String
    Dim _Emp_nic_no As String
    Dim _Emp_ntn_no As String
    Dim _Emp_nic_issue_date As Date
    Dim _Emp_nic_expiry_date As Date
    Dim _Emp_Retirement_age As Integer
    Dim _Emp_birth_date As Date
    Dim _Vehicle_Registration_Number As String
    Dim _Contact_Person_Name As String
    Dim _Relationship As String
    Dim _Contact_address1 As String
    Dim _Contact_address2 As String
    Dim _Contact_home_tel1 As String
    Dim _Contact_home_tel2 As String
    Dim _EOBI_Number As String
    Dim _Emp_Blood_Group As String
    Dim _Employment_Type_code As Integer
    Dim _Emp_category As Integer
    Dim _Emp_Leave_category As Integer
    Dim _Emp_Payroll_category As Integer
    Dim _Shift_code As Integer
    Dim _Desig_code As Integer
    Dim _Dept_code As Integer
    Dim _Cost_Centre_code As Integer
    Dim _Cost_Centre_Name As String
    Dim _Section_code As Integer
    Dim _Grade_code As Integer
    Dim _Edu_code As Integer
    Dim _Loc_code As Integer
    Dim _Transport_code As Integer
    Dim _Religion_Code As Integer
    Dim _Supervisor_Code As Integer
    Dim _Supervisor_Name As String
    Dim _desig_name As String
    Dim _Dept_name As String
    Dim _Grade_name As String
    Dim _Leave_Category_code As Integer
    Dim _Leave_Category_Name As String
    Dim _Section_Name As String
    Dim _emp_confirmationextention As Date
    '----------------------------------------
    Dim _Offer_Letter_Date As Date
    Dim _Tentative_Joining_date As Date
    Dim _RefferedBy As String
    Dim _Notice_period_months As Integer
    '----------------------------------------
    Dim _seaerch As String
    Dim _Loc_Name As String
    Dim _Supervisor As String
    Dim _Div_name As String
    Dim _OrgUnitName As String
    Dim _BusinessSectorName As String
    Dim _PayGradeAreaName As String
    Dim _NIC_ExpiryDate As Date
    Dim _ProbPeriod As Integer
    Dim _ContractMonths As Integer
    Dim _Roster_Group_Code As Integer
    Dim _Nationality As String
    Dim _card_no As String
    Dim _Sharia_Flag As String
    Dim _Profit_Willing_Flag As String
    Dim _Emp_Category_name As String
    Dim _Payroll_Category_code As Integer
    Dim _Payroll_Category_name As String

    Public Property Emp_code() As Integer
        Get
            Return _Emp_code
        End Get
        Set(ByVal value As Integer)
            _Emp_code = value
        End Set
    End Property
    Public Property card_no() As String
        Get
            Return _card_no
        End Get
        Set(ByVal value As String)
            _card_no = value
        End Set
    End Property

    Public Property EOBI_Number() As String
        Get
            Return _EOBI_Number
        End Get
        Set(ByVal value As String)
            _EOBI_Number = value
        End Set
    End Property
    Public Property Sharia_Flag() As String
        Get
            Return _Sharia_Flag
        End Get
        Set(ByVal value As String)
            _Sharia_Flag = value
        End Set
    End Property
    Public Property Salutation_Code() As String
        Get
            Return _Salutation_Code
        End Get
        Set(ByVal value As String)
            _Salutation_Code = value
        End Set
    End Property

    Public Property Emp_Id() As String
        Get
            Return _Emp_Id
        End Get
        Set(ByVal value As String)
            _Emp_Id = value
        End Set
    End Property
    Public Property Company_Employee_Flag() As String
        Get
            Return _Company_Employee_Flag
        End Get
        Set(ByVal value As String)
            _Company_Employee_Flag = value
        End Set
    End Property
    Public Property Emp_sex_code() As String
        Get
            Return _Emp_sex_code
        End Get
        Set(ByVal value As String)
            _Emp_sex_code = value
        End Set
    End Property
    Public Property Emp_marital_status() As String
        Get
            Return _Emp_marital_status
        End Get
        Set(ByVal value As String)
            _Emp_marital_status = value
        End Set
    End Property
    Public Property Emp_name() As String
        Get
            Return _Emp_name
        End Get
        Set(ByVal value As String)
            _Emp_name = value
        End Set
    End Property
    Public Property Emp_Father_name() As String
        Get
            Return _Emp_Father_name
        End Get
        Set(ByVal value As String)
            _Emp_Father_name = value
        End Set
    End Property
    Public Property Emp_appointment_date() As Date
        Get
            Return _Emp_appointment_date
        End Get
        Set(ByVal value As Date)
            _Emp_appointment_date = value
        End Set
    End Property


    Public Property emp_confirmationextention() As Date
        Get
            Return _emp_confirmationextention
        End Get
        Set(ByVal value As Date)
            _emp_confirmationextention = value
        End Set
    End Property

    Public Property Emp_Confirm_date() As Date
        Get
            Return _Emp_Confirm_date
        End Get
        Set(ByVal value As Date)
            _Emp_Confirm_date = value
        End Set
    End Property
    '----------------------------------------
    Public Property Offer_Letter_Date() As Date
        Get
            Return _Offer_Letter_Date
        End Get
        Set(ByVal value As Date)
            _Offer_Letter_Date = value
        End Set
    End Property
    Public Property Tentative_Joining_date() As Date
        Get
            Return _Tentative_Joining_date
        End Get
        Set(ByVal value As Date)
            _Tentative_Joining_date = value
        End Set
    End Property
    Public Property RefferedBy() As String
        Get
            Return _RefferedBy
        End Get
        Set(ByVal value As String)
            _RefferedBy = value
        End Set
    End Property
    Public Property Notice_period_months() As Integer
        Get
            Return _Notice_period_months
        End Get
        Set(ByVal value As Integer)
            _Notice_period_months = value
        End Set
    End Property
    Public Property Emp_Current_address_line1() As String
        Get
            Return _Emp_Current_address_line1
        End Get
        Set(ByVal value As String)
            _Emp_Current_address_line1 = value
        End Set
    End Property
    Public Property Emp_Current_address_line2() As String
        Get
            Return _Emp_Current_address_line2
        End Get
        Set(ByVal value As String)
            _Emp_Current_address_line2 = value
        End Set
    End Property
    Public Property Emp_Permanant_address_line1() As String
        Get
            Return _Emp_Permanant_address_line1
        End Get
        Set(ByVal value As String)
            _Emp_Permanant_address_line1 = value
        End Set
    End Property
    Public Property Emp_Permanant_address_line2() As String
        Get
            Return _Emp_Permanant_address_line2
        End Get
        Set(ByVal value As String)
            _Emp_Permanant_address_line2 = value
        End Set
    End Property
    '----------------------------------------
    Public Property Emp_address_line1() As String
        Get
            Return _Emp_address_line1
        End Get
        Set(ByVal value As String)
            _Emp_address_line1 = value
        End Set
    End Property
    Public Property Emp_address_line2() As String
        Get
            Return _Emp_address_line2
        End Get
        Set(ByVal value As String)
            _Emp_address_line2 = value
        End Set
    End Property
    Public Property Address_City_Code() As Integer
        Get
            Return _Address_City_Code
        End Get
        Set(ByVal value As Integer)
            _Address_City_Code = value
        End Set
    End Property
    Public Property Emp_home_tel1() As String
        Get
            Return _Emp_home_tel1
        End Get
        Set(ByVal value As String)
            _Emp_home_tel1 = value
        End Set
    End Property
    Public Property Emp_home_tel2() As String
        Get
            Return _Emp_home_tel2
        End Get
        Set(ByVal value As String)
            _Emp_home_tel2 = value
        End Set
    End Property
    Public Property Emp_office_tel1() As String
        Get
            Return _Emp_office_tel1
        End Get
        Set(ByVal value As String)
            _Emp_office_tel1 = value
        End Set
    End Property
    Public Property Emp_office_tel2() As String
        Get
            Return _Emp_office_tel2
        End Get
        Set(ByVal value As String)
            _Emp_office_tel2 = value
        End Set
    End Property
    Public Property Emp_mobile_No() As String
        Get
            Return _Emp_mobile_No
        End Get
        Set(ByVal value As String)
            _Emp_mobile_No = value
        End Set
    End Property
    Public Property Official_Mobile_No() As String
        Get
            Return _Official_Mobile_No
        End Get
        Set(ByVal value As String)
            _Official_Mobile_No = value
        End Set
    End Property
    Public Property Emp_email() As String
        Get
            Return _Emp_email
        End Get
        Set(ByVal value As String)
            _Emp_email = value
        End Set
    End Property
    Public Property Emp_nic_no() As String
        Get
            Return _Emp_nic_no
        End Get
        Set(ByVal value As String)
            _Emp_nic_no = value
        End Set
    End Property
    Public Property Emp_NIC_Issue_date() As Date
        Get
            Return _Emp_nic_issue_date
        End Get
        Set(ByVal value As Date)
            _Emp_nic_issue_date = value
        End Set
    End Property
    Public Property Emp_NIC_Expiry_date() As Date
        Get
            Return _Emp_nic_expiry_date
        End Get
        Set(ByVal value As Date)
            _Emp_nic_expiry_date = value
        End Set
    End Property
    Public Property Emp_Retirement_age() As Integer
        Get
            Return _Emp_Retirement_age
        End Get
        Set(ByVal value As Integer)
            _Emp_Retirement_age = value
        End Set
    End Property
    Public Property Emp_ntn_no() As String
        Get
            Return _Emp_ntn_no
        End Get
        Set(ByVal value As String)
            _Emp_ntn_no = value
        End Set
    End Property
    Public Property Emp_birth_date() As Date
        Get
            Return _Emp_birth_date
        End Get
        Set(ByVal value As Date)
            _Emp_birth_date = value
        End Set
    End Property
    Public Property Vehicle_Registration_Number() As String
        Get
            Return _Vehicle_Registration_Number
        End Get
        Set(ByVal value As String)
            _Vehicle_Registration_Number = value
        End Set
    End Property
    Public Property Contact_Person_Name() As String
        Get
            Return _Contact_Person_Name
        End Get
        Set(ByVal value As String)
            _Contact_Person_Name = value
        End Set
    End Property
    Public Property Relationship() As String
        Get
            Return _Relationship
        End Get
        Set(ByVal value As String)
            _Relationship = value
        End Set
    End Property
    Public Property Contact_address1() As String
        Get
            Return _Contact_address1
        End Get
        Set(ByVal value As String)
            _Contact_address1 = value
        End Set
    End Property
    Public Property Contact_address2() As String
        Get
            Return _Contact_address2
        End Get
        Set(ByVal value As String)
            _Contact_address2 = value
        End Set
    End Property
    Public Property Contact_home_tel1() As String
        Get
            Return _Contact_home_tel1
        End Get
        Set(ByVal value As String)
            _Contact_home_tel1 = value
        End Set
    End Property
    Public Property Contact_home_tel2() As String
        Get
            Return _Contact_home_tel2
        End Get
        Set(ByVal value As String)
            _Contact_home_tel2 = value
        End Set
    End Property
    Public Property Emp_Blood_Group() As String
        Get
            Return _Emp_Blood_Group
        End Get
        Set(ByVal value As String)
            _Emp_Blood_Group = value
        End Set
    End Property
    Public Property Employment_Type_code() As Integer
        Get
            Return _Employment_Type_code
        End Get
        Set(ByVal value As Integer)
            _Employment_Type_code = value
        End Set
    End Property
    Public Property Emp_category() As Integer
        Get
            Return _Emp_category
        End Get
        Set(ByVal value As Integer)
            _Emp_category = value
        End Set
    End Property

    Public Property Emp_Leave_category() As Integer
        Get
            Return _Emp_Leave_category
        End Get
        Set(ByVal value As Integer)
            _Emp_Leave_category = value
        End Set
    End Property
    Public Property Emp_Payroll_category() As Integer
        Get
            Return _Emp_Payroll_category
        End Get
        Set(ByVal value As Integer)
            _Emp_Payroll_category = value
        End Set
    End Property
    Public Property Shift_code() As Integer
        Get
            Return _Shift_code
        End Get
        Set(ByVal value As Integer)
            _Shift_code = value
        End Set
    End Property
    Public Property Desig_code() As Integer
        Get
            Return _Desig_code
        End Get
        Set(ByVal value As Integer)
            _Desig_code = value
        End Set
    End Property
    Public Property Dept_code() As Integer
        Get
            Return _Dept_code
        End Get
        Set(ByVal value As Integer)
            _Dept_code = value
        End Set
    End Property
    Public Property Cost_Centre_code() As Integer
        Get
            Return _Cost_Centre_code
        End Get
        Set(ByVal value As Integer)
            _Cost_Centre_code = value
        End Set
    End Property
    Public Property Cost_Centre_Name() As String
        Get
            Return _Cost_Centre_Name
        End Get
        Set(ByVal value As String)
            _Cost_Centre_Name = value
        End Set
    End Property
    Public Property Section_code() As Integer
        Get
            Return _Section_code
        End Get
        Set(ByVal value As Integer)
            _Section_code = value
        End Set
    End Property
    Public Property Grade_code() As Integer
        Get
            Return _Grade_code
        End Get
        Set(ByVal value As Integer)
            _Grade_code = value
        End Set
    End Property
    Public Property Edu_code() As Integer
        Get
            Return _Edu_code
        End Get
        Set(ByVal value As Integer)
            _Edu_code = value
        End Set
    End Property
    Public Property Loc_code() As Integer
        Get
            Return _Loc_code
        End Get
        Set(ByVal value As Integer)
            _Loc_code = value
        End Set
    End Property
    Public Property Transport_code() As Integer
        Get
            Return _Transport_code
        End Get
        Set(ByVal value As Integer)
            _Transport_code = value
        End Set
    End Property
    Public Property Religion_Code() As Integer
        Get
            Return _Religion_Code
        End Get
        Set(ByVal value As Integer)
            _Religion_Code = value
        End Set
    End Property
    Public Property Supervisor_Code() As Integer
        Get
            Return _Supervisor_Code
        End Get
        Set(ByVal value As Integer)
            _Supervisor_Code = value
        End Set
    End Property
    Public Property Supervisor_Name() As String
        Get
            Return _Supervisor_Name
        End Get
        Set(ByVal value As String)
            _Supervisor_Name = value
        End Set
    End Property
    Public Property desig_name() As String
        Get
            Return _desig_name
        End Get
        Set(ByVal value As String)
            _desig_name = value
        End Set
    End Property
    Public Property Dept_name() As String
        Get
            Return _Dept_name
        End Get
        Set(ByVal value As String)
            _Dept_name = value
        End Set
    End Property

    Public Property Leave_Category_code() As Integer
        Get
            Return _Leave_Category_code
        End Get
        Set(ByVal value As Integer)
            _Leave_Category_code = value
        End Set
    End Property
    Public Property Leave_Category_Name() As String
        Get
            Return _Leave_Category_Name
        End Get
        Set(ByVal value As String)
            Leave_Category_Name = value
        End Set
    End Property
    Public Property Grade_name() As String
        Get
            Return _Grade_name
        End Get
        Set(ByVal value As String)
            _Grade_name = value
        End Set
    End Property
    Public Property Section_Name() As String
        Get
            Return _Section_Name
        End Get
        Set(ByVal value As String)
            _Section_Name = value
        End Set
    End Property
    Public Property Loc_Name() As String
        Get
            Return _Loc_Name
        End Get
        Set(ByVal value As String)
            _Loc_Name = value
        End Set
    End Property
    Public Property Supervisor() As String
        Get
            Return _Supervisor
        End Get
        Set(ByVal value As String)
            _Supervisor = value
        End Set
    End Property
    Public Property Div_Name() As String
        Get
            Return _Div_name
        End Get
        Set(ByVal value As String)
            _Div_name = value
        End Set
    End Property
    Public Property OrgUnitName() As String
        Get
            Return _OrgUnitName
        End Get
        Set(ByVal value As String)
            _OrgUnitName = value
        End Set
    End Property
    Public Property PayGradeAreaName() As String
        Get
            Return _PayGradeAreaName
        End Get
        Set(ByVal value As String)
            _PayGradeAreaName = value
        End Set
    End Property
    Public Property BusinessSectorName() As String
        Get
            Return _BusinessSectorName
        End Get
        Set(ByVal value As String)
            _BusinessSectorName = value
        End Set
    End Property
    Public Property NIC_ExpiryDate() As Date
        Get
            Return _NIC_ExpiryDate
        End Get
        Set(ByVal value As Date)
            _NIC_ExpiryDate = value
        End Set
    End Property
    Public Property ProbPeriod() As Integer
        Get
            Return _ProbPeriod
        End Get
        Set(ByVal value As Integer)
            _ProbPeriod = value
        End Set
    End Property
    Public Property ContractMonths() As Integer
        Get
            Return _ContractMonths
        End Get
        Set(ByVal value As Integer)
            _ContractMonths = value
        End Set
    End Property
    Public Property Nationality() As String
        Get
            Return _Nationality
        End Get
        Set(ByVal value As String)
            _Nationality = value
        End Set
    End Property
    Public Property Roster_Group_Code() As Integer
        Get
            Return _Roster_Group_Code
        End Get
        Set(ByVal value As Integer)
            _Roster_Group_Code = value
        End Set
    End Property
    Public Property Profit_Willing_Flag() As String
        Get
            Return _Profit_Willing_Flag
        End Get
        Set(ByVal value As String)
            _Profit_Willing_Flag = value
        End Set
    End Property

    Public Property Emp_Category_name() As String
        Get
            Return _Emp_Category_name
        End Get
        Set(ByVal value As String)
            _Emp_Category_name = value
        End Set
    End Property
    Public Property Payroll_Category_code() As Integer
        Get
            Return _Payroll_Category_code
        End Get
        Set(ByVal value As Integer)
            _Payroll_Category_code = value
        End Set
    End Property
    Public Property Payroll_Category_name() As String
        Get
            Return _Payroll_Category_name
        End Get
        Set(ByVal value As String)
            _Payroll_Category_name = value
        End Set
    End Property
End Class

Public Class MasterEmployeesDB
    Public Shared Function getMasterEmployee_List_Section(ByVal Code As Integer) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_List_Section", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim EmpCode As New SqlParameter("@EmpCode", SqlDbType.Int, ParameterDirection.Input)
        EmpCode.Value = Code
        cmd.Parameters.Add(EmpCode)



        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function



    Public Shared Function getMasterEmployee_Search_Section(ByVal Code As Integer, ByVal SType As Char, ByVal Val As String) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_Search_Section", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim EmpCode As New SqlParameter("@EmpCode", SqlDbType.Int, ParameterDirection.Input)
        EmpCode.Value = Code
        cmd.Parameters.Add(EmpCode)

        Dim SearchType As New SqlParameter("@SearchType", SqlDbType.Char, 1, ParameterDirection.Input)
        SearchType.Value = SType
        cmd.Parameters.Add(SearchType)

        Dim Value As New SqlParameter("@Value", SqlDbType.VarChar, 100, ParameterDirection.Input)
        Value.Value = Val
        cmd.Parameters.Add(Value)


        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function


    Public Shared Function get_emp_code(ByVal empcode As Integer) As MasterEmployeesInfo

        'Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        'Dim cmd As New SqlCommand("SP_getEmp_code_from_EmpId", cn)
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.AddWithValue("@emp_id", empcode)
        'Dim da As New SqlDataAdapter(cmd)
        'Dim ds As New DataSet

        Dim rdr As SqlDataReader
        Dim Employee As New MasterEmployeesInfo
        Try
            'cn.Open()
            'rdr = cmd.ExecuteReader()
            'rdr.Read()
            With Employee
                .Emp_code = empcode

            End With
            '(rdr.Item("Emp_code"))
            Return Employee
        Catch ex As Exception
            Throw ex
        Finally
            'rdr.Close()
            'cn.Close()
            'rdr = Nothing
            'cn = Nothing
        End Try
    End Function


    Public Shared Function get_emp_code_from_ALL_EmployeesTable(ByVal empcode As String) As MasterEmployeesInfo

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_getEmp_code_from_EmpId_ALL_EMPLOYEES", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@emp_id", empcode)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Dim rdr As SqlDataReader
        Dim Employee As New MasterEmployeesInfo
        Try
            cn.Open()
            rdr = cmd.ExecuteReader()
            rdr.Read()
            With Employee
                .Emp_code = (rdr.Item("Emp_code"))
            End With
            Return Employee
        Catch ex As Exception
            Throw ex
        Finally
            rdr.Close()
            cn.Close()
            rdr = Nothing
            cn = Nothing
        End Try
    End Function

    Public Shared Function getMasterEmployeeByCodeWithDesc(ByVal Code As Integer) As MasterEmployeesInfo
        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_ListByCodeDesc", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim EmpCode As New SqlParameter("@EmpCode", SqlDbType.Int, ParameterDirection.Input)
        EmpCode.Value = Code
        cmd.Parameters.Add(EmpCode)

        Dim rdr As SqlDataReader
        Dim Employee As New MasterEmployeesInfo

        Try
            cn.Open()
            rdr = cmd.ExecuteReader
            rdr.Read()

            With Employee
                .Emp_code = rdr.Item("Emp_code")
                .Emp_Id = rdr.Item("Emp_Id")
                .Emp_name = rdr.Item("Emp_name")
                .desig_name = rdr.Item("Desig_name")
                .Grade_code = rdr.Item("Grade_code")
                .Grade_Name = rdr.item("Grade_Name")
                .Leave_Category_code = rdr.Item("Emp_Leave_Category")
                .Leave_Category_Name = rdr.Item("Leave_Category_Name")
                .Emp_appointment_date = rdr.Item("Emp_appointment_date")
                .Emp_Confirm_date = rdr.Item("emp_confirm_date")
                .Emp_category = rdr.Item("Emp_category")
                .Section_Name = rdr.Item("Section_Name")
                .Dept_name = rdr.Item("Department_Name")
                .Div_Name = rdr.Item("div_name")
                .Cost_Centre_code = rdr.Item("Cost_Centre_code")
                .Cost_Centre_Name = rdr.Item("Cost_Centre_name")
                .Loc_code = rdr.Item("Loc_code")
                .Loc_Name = rdr.Item("Loc_name")
                .Supervisor_Code = rdr.Item("Supervisor_Code")
                .Supervisor_Name = rdr.Item("Supervisor_Name")
                .Emp_category_Name = rdr.Item("Emp_Category_name")
                .Payroll_category_Code = rdr.Item("Payroll_Category_code")
                .Payroll_category_Name = rdr.Item("Payroll_Category_name")
            End With

            Return Employee
        Catch ex As Exception
            Employee.Emp_code = -1
            Return Employee
            'Throw ex
        Finally

            rdr.Close()
            cn.Close()
            rdr = Nothing
            cn = Nothing

        End Try

    End Function



    Public Shared Function getMasterEmployeeByCodeWithDescresigned(ByVal Code As Integer) As MasterEmployeesInfo
        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_ListByCodeDesc_resigned", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim EmpCode As New SqlParameter("@EmpCode", SqlDbType.Int, ParameterDirection.Input)
        EmpCode.Value = Code
        cmd.Parameters.Add(EmpCode)

        Dim rdr As SqlDataReader
        Dim Employee As New MasterEmployeesInfo

        Try
            cn.Open()
            rdr = cmd.ExecuteReader
            rdr.Read()

            With Employee
                .Emp_code = rdr.Item("Emp_code")
                .Emp_name = rdr.Item("Emp_name")
                .desig_name = rdr.Item("Desig_name")
                .Grade_code = rdr.Item("Grade_code")
                .Grade_name = rdr.Item("Grade_Name")
                .Leave_Category_code = rdr.Item("Emp_Leave_Category")
                .Emp_appointment_date = rdr.Item("Emp_appointment_date")
                .Emp_Confirm_date = rdr.Item("emp_confirm_date")
                .Emp_category = rdr.Item("Emp_category")
                .Section_Name = rdr.Item("Section_Name")
                .Dept_name = rdr.Item("Section_Name")
            End With

            Return Employee
        Catch ex As Exception
            Employee.Emp_code = -1
            Return Employee
            'Throw ex
        Finally

            rdr.Close()
            cn.Close()
            rdr = Nothing
            cn = Nothing

        End Try

    End Function


    Public Shared Function getMasterEmployeeByCodeWithDesc_extendedconfirmation(ByVal Code As Integer) As MasterEmployeesInfo
        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_ListByCodeDesc_extendedconfirmation", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim EmpCode As New SqlParameter("@EmpCode", SqlDbType.Int, ParameterDirection.Input)
        EmpCode.Value = Code
        cmd.Parameters.Add(EmpCode)

        Dim rdr As SqlDataReader
        Dim Employee As New MasterEmployeesInfo

        Try
            cn.Open()
            rdr = cmd.ExecuteReader
            rdr.Read()

            With Employee
                .Emp_code = rdr.Item("Emp_code")
                .Emp_Id = rdr.Item("Emp_Id")
                .Emp_name = rdr.Item("Emp_name")
                .desig_name = rdr.Item("Desig_name")
                .Grade_code = rdr.Item("Grade_code")
                .Grade_name = rdr.Item("Grade_Name")
                .Leave_Category_code = rdr.Item("Emp_Leave_Category")
                .Emp_appointment_date = rdr.Item("Emp_appointment_date")
                .Emp_Confirm_date = rdr.Item("emp_confirm_date")
                .Emp_category = rdr.Item("Emp_category")
                .Section_Name = rdr.Item("Section_Name")
                .Dept_name = rdr.Item("Section_Name")
                .emp_confirmationextention = rdr.Item("Confirmation_Extended_Date")
            End With

            Return Employee
        Catch ex As Exception
            Employee.Emp_code = -1
            Return Employee
            'Throw ex
        Finally

            rdr.Close()
            cn.Close()
            rdr = Nothing
            cn = Nothing

        End Try

    End Function






    Public Shared Function getMasterEmployeeByCode(ByVal Code As Integer) As MasterEmployeesInfo
        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_ListByCode", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim EmpCode As New SqlParameter("@Code", SqlDbType.Int, ParameterDirection.Input)
        EmpCode.Value = Code
        cmd.Parameters.Add(EmpCode)

        Dim rdr As SqlDataReader
        Dim Employee As New MasterEmployeesInfo

        Try
            cn.Open()
            rdr = cmd.ExecuteReader
            rdr.Read()

            With Employee
                .Salutation_Code = rdr.Item("Salutation_Code")
                .Emp_code = rdr.Item("Emp_code")
                .Emp_Id = rdr.Item("Emp_Id")
                .Company_Employee_Flag = rdr.Item("Company_Employee_Flag")
                .Emp_sex_code = rdr.Item("Emp_sex_code")
                .Emp_marital_status = rdr.Item("Emp_marital_status")
                .Emp_name = rdr.Item("Emp_name")
                .Emp_Father_name = rdr.Item("Emp_Father_name")
                .Emp_appointment_date = rdr.Item("Emp_appointment_date")
                .Emp_Confirm_date = rdr.Item("Confirm_date")
                .Emp_Current_address_line1 = rdr.Item("Emp_Current_address_line1")
                .Emp_Current_address_line2 = rdr.Item("Emp_Current_address_line2")
                .Emp_Permanant_address_line1 = rdr.Item("Emp_Permanant_address_line1")
                .Emp_Permanant_address_line2 = rdr.Item("Emp_Permanant_address_line2")
                .Emp_address_line1 = IIf(IsDBNull(rdr.Item("Emp_address_line1")) = True, "N/A", rdr.Item("Emp_address_line1"))
                .Emp_address_line2 = IIf(IsDBNull(rdr.Item("Emp_address_line2")) = True, "N/A", rdr.Item("Emp_address_line2"))
                .Address_City_Code = rdr.Item("Address_City_Code")
                .Emp_home_tel1 = IIf(IsDBNull(rdr.Item("Emp_home_tel1")) = True, 0, rdr.Item("Emp_home_tel1"))
                .Emp_home_tel2 = IIf(IsDBNull(rdr.Item("Emp_home_tel2")) = True, 0, rdr.Item("Emp_home_tel2"))
                .Emp_office_tel1 = IIf(IsDBNull(rdr.Item("Emp_office_tel1")) = True, 0, rdr.Item("Emp_office_tel1"))
                .Emp_office_tel2 = IIf(IsDBNull(rdr.Item("Emp_office_tel2")) = True, 0, rdr.Item("Emp_office_tel2"))
                .Emp_mobile_No = IIf(IsDBNull(rdr.Item("Emp_mobile_No")) = True, 0, rdr.Item("Emp_mobile_No"))
                .Official_Mobile_No = rdr.Item("Official_Mobile_No")
                .Emp_email = rdr.Item("Emp_email")
                .Emp_nic_no = rdr.Item("Emp_nic_no")
                .Emp_NIC_Issue_date = rdr.Item("Emp_nic_issue_date")
                .Emp_NIC_Expiry_date = rdr.Item("Emp_nic_expiry_date")
                .Emp_Retirement_age = rdr.Item("Emp_retirement_age")
                .Emp_ntn_no = rdr.Item("Emp_ntn_no")
                .Emp_birth_date = rdr.Item("Emp_birth_date")
                .Vehicle_Registration_Number = rdr.Item("Vehicle_Registration_Number")
                .Contact_Person_Name = rdr.Item("Contact_Person_Name")
                .Relationship = rdr.Item("Relationship")
                .Contact_address1 = rdr.Item("Contact_address1")
                .Contact_address2 = rdr.Item("Contact_address2")
                .Contact_home_tel1 = rdr.Item("Contact_home_tel1")
                .Contact_home_tel2 = rdr.Item("Contact_home_tel2")
                .Emp_Blood_Group = rdr.Item("Emp_Blood_Group")
                .Employment_Type_code = rdr.Item("Employment_Type_code")
                .Emp_category = rdr.Item("Emp_category")
                .Emp_Leave_category = rdr.Item("Emp_Leave_category")
                .Emp_Payroll_category = rdr.Item("Emp_Payroll_category")
                .Shift_code = rdr.Item("Shift_code")
                .Desig_code = rdr.Item("Desig_code")
                .EOBI_Number = rdr.Item("EOBI_Number")
                .Dept_code = rdr.Item("Department_Code")
                .Cost_Centre_code = rdr.Item("Cost_Centre_code")
                .Section_code = rdr.Item("Section_code")
                .Grade_code = rdr.Item("Grade_code")
                .Edu_code = rdr.Item("Edu_code")
                .Loc_code = rdr.Item("Loc_code")
                .Religion_Code = rdr.Item("Religion_Code")
                .Supervisor_Code = rdr.Item("Supervisor_Code")
                .Dept_name = rdr.Item("dept_name")
                .Loc_Name = rdr.Item("Loc_Name")
                .Grade_name = rdr.Item("Grade_name")
                .Supervisor = rdr.Item("Supervisor")
                .desig_name = rdr.Item("Desig_name")
                .Div_Name = rdr.Item("Div_name")
                .OrgUnitName = rdr.Item("org_unit_name")
                .BusinessSectorName = rdr.Item("Business_Sector_Name")
                .PayGradeAreaName = rdr.Item("Pay_Grade_Area_Name")
                .NIC_ExpiryDate = rdr.Item("Emp_nic_expiry_date")
                .Offer_Letter_Date = rdr.Item("Offer_Letter_Date")
                .Tentative_Joining_date = rdr.Item("Tentative_Joining_date")
                .RefferedBy = rdr.Item("RefferedBy")
                .ProbPeriod = rdr.Item("Probationary_period_months")
                .Notice_period_months = rdr.Item("Notice_period_months")
                .Roster_Group_Code = rdr.Item("roster_group_code")
                .Nationality = rdr.Item("Nationality")
                .card_no = rdr.Item("card_no")
                .Sharia_Flag = rdr.Item("Sharia_Flag")
                .Profit_Willing_Flag = rdr.Item("Profit_Willing_Flag")
                .Payroll_Category_code = rdr.Item("Emp_Payroll_category")
            End With

            Return Employee
        Catch ex As Exception
            Throw ex
        Finally
            rdr.Close()
            cn.Close()
            rdr = Nothing
            cn = Nothing

        End Try
    End Function

    Public Shared Function getEmploeeStructure(ByVal Code As Integer) As MasterEmployeesInfo
        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("get_Emp_Structure", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim EmpCode As New SqlParameter("@Code", SqlDbType.Int, ParameterDirection.Input)
        EmpCode.Value = Code
        cmd.Parameters.Add(EmpCode)

        Dim rdr As SqlDataReader
        Dim Employee As New MasterEmployeesInfo

        Try
            cn.Open()
            rdr = cmd.ExecuteReader
            rdr.Read()

            With Employee
                .Desig_code = rdr.Item("Desig_code")
                .Cost_Centre_code = rdr.Item("Cost_Centre_code")
                .Section_code = rdr.Item("Section_code")
                .Grade_code = rdr.Item("Grade_code")
                .Loc_code = rdr.Item("Loc_code")

            End With

            Return Employee
        Catch ex As Exception
            Throw ex
        Finally
            rdr.Close()
            cn.Close()
            rdr = Nothing
            cn = Nothing

        End Try
    End Function

    Public Shared Function getMasterEmployeeByCoderesignedall(ByVal Code As Integer) As MasterEmployeesInfo
        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_ListByCode_resignedall", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim EmpCode As New SqlParameter("@Code", SqlDbType.Int, ParameterDirection.Input)
        EmpCode.Value = Code
        cmd.Parameters.Add(EmpCode)

        Dim rdr As SqlDataReader
        Dim Employee As New MasterEmployeesInfo

        Try
            cn.Open()
            rdr = cmd.ExecuteReader
            rdr.Read()

            With Employee
                .Emp_code = rdr.Item("Emp_code")
                .Company_Employee_Flag = rdr.Item("Company_Employee_Flag")
                .Emp_sex_code = rdr.Item("Emp_sex_code")
                .Emp_marital_status = rdr.Item("Emp_marital_status")
                .Emp_name = rdr.Item("Emp_name")
                .Emp_Father_name = rdr.Item("Emp_Father_name")
                .Emp_appointment_date = rdr.Item("Emp_appointment_date")
                .Emp_Confirm_date = rdr.Item("Emp_Confirm_date")
                .Emp_address_line1 = IIf(IsDBNull(rdr.Item("Emp_address_line1")) = True, "N/A", rdr.Item("Emp_address_line1"))
                .Emp_address_line2 = IIf(IsDBNull(rdr.Item("Emp_address_line2")) = True, "N/A", rdr.Item("Emp_address_line2"))
                .Emp_home_tel1 = IIf(IsDBNull(rdr.Item("Emp_home_tel1")) = True, 0, rdr.Item("Emp_home_tel1"))
                .Emp_home_tel2 = IIf(IsDBNull(rdr.Item("Emp_home_tel2")) = True, 0, rdr.Item("Emp_home_tel2"))
                .Emp_office_tel1 = IIf(IsDBNull(rdr.Item("Emp_office_tel1")) = True, 0, rdr.Item("Emp_office_tel1"))
                .Emp_office_tel2 = IIf(IsDBNull(rdr.Item("Emp_office_tel2")) = True, 0, rdr.Item("Emp_office_tel2"))
                .Emp_mobile_No = IIf(IsDBNull(rdr.Item("Emp_mobile_No")) = True, 0, rdr.Item("Emp_mobile_No"))
                .Emp_email = rdr.Item("Emp_email")
                .Emp_nic_no = rdr.Item("Emp_nic_no")
                .Emp_ntn_no = rdr.Item("Emp_ntn_no")
                .Emp_birth_date = rdr.Item("Emp_birth_date")
                .Vehicle_Registration_Number = rdr.Item("Vehicle_Registration_Number")
                .Contact_Person_Name = rdr.Item("Contact_Person_Name")
                .Relationship = rdr.Item("Relationship")
                .Contact_address1 = rdr.Item("Contact_address1")
                .Contact_address2 = rdr.Item("Contact_address2")
                .Contact_home_tel1 = rdr.Item("Contact_home_tel1")
                .Contact_home_tel2 = rdr.Item("Contact_home_tel2")
                .Emp_Blood_Group = rdr.Item("Emp_Blood_Group")
                .Employment_Type_code = rdr.Item("Employment_Type_code")
                .Emp_category = rdr.Item("Emp_category")
                .Emp_Leave_category = rdr.Item("Emp_Leave_category")
                .Emp_Payroll_category = rdr.Item("Emp_Payroll_category")
                .Shift_code = rdr.Item("Shift_code")
                .Desig_code = rdr.Item("Desig_code")
                .Dept_code = rdr.Item("Dept_code")
                .Cost_Centre_code = rdr.Item("Cost_Centre_code")
                .Section_code = rdr.Item("Section_code")
                .Grade_code = rdr.Item("Grade_code")
                .Edu_code = rdr.Item("Edu_code")
                .Loc_code = rdr.Item("Loc_code")
                .Transport_code = rdr.Item("Transport_code")
                .Religion_Code = rdr.Item("Religion_Code")
                .Supervisor_Code = rdr.Item("Supervisor_Code")
            End With

            Return Employee
        Catch ex As Exception
            Throw ex
        Finally
            rdr.Close()
            cn.Close()
            rdr = Nothing
            cn = Nothing

        End Try
    End Function

    Public Shared Function getMasterAppointmentByCode(ByVal Code As Integer) As MasterEmployeesInfo
        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterAppointment_ListByCode", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim EmpCode As New SqlParameter("@Code", SqlDbType.Int, ParameterDirection.Input)
        EmpCode.Value = Code
        cmd.Parameters.Add(EmpCode)

        Dim rdr As SqlDataReader
        Dim Employee As New MasterEmployeesInfo

        Try
            cn.Open()
            rdr = cmd.ExecuteReader
            rdr.Read()

            With Employee
                .Emp_code = rdr.Item("Emp_code")
                .Company_Employee_Flag = rdr.Item("Company_Employee_Flag")
                .Emp_sex_code = rdr.Item("Emp_sex_code")
                .Emp_marital_status = rdr.Item("Emp_marital_status")
                .Emp_name = rdr.Item("Emp_name")
                .Emp_Father_name = rdr.Item("Emp_Father_name")
                .Emp_appointment_date = rdr.Item("Emp_appointment_date")
                .Emp_Confirm_date = rdr.Item("Emp_Confirm_date")
                .Emp_address_line1 = IIf(IsDBNull(rdr.Item("Emp_address_line1")) = True, "N/A", rdr.Item("Emp_address_line1"))
                .Emp_address_line2 = IIf(IsDBNull(rdr.Item("Emp_address_line2")) = True, "N/A", rdr.Item("Emp_address_line2"))
                .Emp_home_tel1 = IIf(IsDBNull(rdr.Item("Emp_home_tel1")) = True, 0, rdr.Item("Emp_home_tel1"))
                .Emp_home_tel2 = IIf(IsDBNull(rdr.Item("Emp_home_tel2")) = True, 0, rdr.Item("Emp_home_tel2"))
                .Emp_office_tel1 = IIf(IsDBNull(rdr.Item("Emp_office_tel1")) = True, 0, rdr.Item("Emp_office_tel1"))
                .Emp_office_tel2 = IIf(IsDBNull(rdr.Item("Emp_office_tel2")) = True, 0, rdr.Item("Emp_office_tel2"))
                .Emp_mobile_No = IIf(IsDBNull(rdr.Item("Emp_mobile_No")) = True, 0, rdr.Item("Emp_mobile_No"))
                .Emp_email = rdr.Item("Emp_email")
                .Emp_nic_no = rdr.Item("Emp_nic_no")
                .Emp_ntn_no = rdr.Item("Emp_ntn_no")
                .Emp_birth_date = rdr.Item("Emp_birth_date")
                .Vehicle_Registration_Number = rdr.Item("Vehicle_Registration_Number")
                .Contact_Person_Name = rdr.Item("Contact_Person_Name")
                .Relationship = rdr.Item("Relationship")
                .Contact_address1 = rdr.Item("Contact_address1")
                .Contact_address2 = rdr.Item("Contact_address2")
                .Contact_home_tel1 = rdr.Item("Contact_home_tel1")
                .Contact_home_tel2 = rdr.Item("Contact_home_tel2")
                .Emp_Blood_Group = rdr.Item("Emp_Blood_Group")
                .Employment_Type_code = rdr.Item("empt_type_code")
                .Emp_category = rdr.Item("Emp_category")
                .Emp_Leave_category = rdr.Item("Emp_Leave_category")
                .Emp_Payroll_category = rdr.Item("Emp_Payroll_category")
                .Shift_code = rdr.Item("Shift_code")
                .Desig_code = rdr.Item("Desig_code")
                .Dept_code = rdr.Item("Dept_code")
                .Cost_Centre_code = rdr.Item("Cost_Centre_code")
                .Section_code = rdr.Item("Section_code")
                .Grade_code = rdr.Item("Grade_code")
                .Edu_code = rdr.Item("Edu_code")
                .Loc_code = rdr.Item("Loc_code")
                .Transport_code = rdr.Item("Transport_code")
                .Religion_Code = rdr.Item("Religion_Code")
                .Supervisor_Code = rdr.Item("Supervisor_Code")
            End With

            Return Employee
        Catch ex As Exception
            Throw ex
        Finally
            rdr.Close()
            cn.Close()
            rdr = Nothing
            cn = Nothing

        End Try
    End Function

    Public Shared Function getMasterEmployee_List() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_List", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@User_Code", System.Web.HttpContext.Current.Session("Emp_code"))
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function
    Public Shared Function getMasterAllEmployee_List() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterAllEmployees_List", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function

    Public Shared Function getMasterAllEmployee_List_with_code() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterAllEmployees_List_code", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function
    Public Shared Function getMasterAllEmployeeByCodeWithDesc(ByVal Code As Integer) As MasterEmployeesInfo
        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterAllEmployees_ListByCodeDesc", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim EmpCode As New SqlParameter("@EmpCode", SqlDbType.Int, ParameterDirection.Input)
        EmpCode.Value = Code
        cmd.Parameters.Add(EmpCode)

        Dim rdr As SqlDataReader
        Dim Employee As New MasterEmployeesInfo

        Try
            cn.Open()
            rdr = cmd.ExecuteReader
            rdr.Read()

            With Employee
                .Emp_code = rdr.Item("Emp_code")
                .Emp_name = rdr.Item("Emp_name")
                .desig_name = rdr.Item("Desig_name")
                .Grade_code = rdr.Item("Grade_code")
                .Grade_name = rdr.Item("Grade_Name")
                .Leave_Category_code = rdr.Item("Emp_Leave_Category")
                .Emp_appointment_date = rdr.Item("Emp_appointment_date")
                .Emp_Confirm_date = rdr.Item("emp_confirm_date")
                .Emp_category = rdr.Item("Emp_category")
                .Section_Name = rdr.Item("Section_Name")
                .Dept_name = rdr.Item("Section_Name")
            End With

            Return Employee
        Catch ex As Exception
            Employee.Emp_code = -1
            Return Employee
            'Throw ex
        Finally

            rdr.Close()
            cn.Close()
            rdr = Nothing
            cn = Nothing

        End Try

    End Function
    Public Shared Function getMasterAllEmployeeByCode(ByVal Code As Integer) As MasterEmployeesInfo
        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterAllEmployees_ListByCode", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim EmpCode As New SqlParameter("@Code", SqlDbType.Int, ParameterDirection.Input)
        EmpCode.Value = Code
        cmd.Parameters.Add(EmpCode)

        Dim rdr As SqlDataReader
        Dim Employee As New MasterEmployeesInfo

        Try
            cn.Open()
            rdr = cmd.ExecuteReader
            rdr.Read()

            With Employee
                .Emp_code = rdr.Item("Emp_code")
                .Company_Employee_Flag = rdr.Item("Company_Employee_Flag")
                .Emp_sex_code = rdr.Item("Emp_sex_code")
                .Emp_marital_status = rdr.Item("Emp_marital_status")
                .Emp_name = rdr.Item("Emp_name")
                .Emp_Father_name = rdr.Item("Emp_Father_name")
                .Emp_appointment_date = rdr.Item("Emp_appointment_date")
                .Emp_Confirm_date = rdr.Item("Emp_Confirm_date")
                .Emp_address_line1 = IIf(IsDBNull(rdr.Item("Emp_address_line1")) = True, "N/A", rdr.Item("Emp_address_line1"))
                .Emp_address_line2 = IIf(IsDBNull(rdr.Item("Emp_address_line2")) = True, "N/A", rdr.Item("Emp_address_line2"))
                .Emp_home_tel1 = IIf(IsDBNull(rdr.Item("Emp_home_tel1")) = True, 0, rdr.Item("Emp_home_tel1"))
                .Emp_home_tel2 = IIf(IsDBNull(rdr.Item("Emp_home_tel2")) = True, 0, rdr.Item("Emp_home_tel2"))
                .Emp_office_tel1 = IIf(IsDBNull(rdr.Item("Emp_office_tel1")) = True, 0, rdr.Item("Emp_office_tel1"))
                .Emp_office_tel2 = IIf(IsDBNull(rdr.Item("Emp_office_tel2")) = True, 0, rdr.Item("Emp_office_tel2"))
                .Emp_mobile_No = IIf(IsDBNull(rdr.Item("Emp_mobile_No")) = True, 0, rdr.Item("Emp_mobile_No"))
                .Emp_email = rdr.Item("Emp_email")
                .Emp_nic_no = rdr.Item("Emp_nic_no")
                .Emp_ntn_no = rdr.Item("Emp_ntn_no")
                .Emp_birth_date = rdr.Item("Emp_birth_date")
                .Vehicle_Registration_Number = rdr.Item("Vehicle_Registration_Number")
                .Contact_Person_Name = rdr.Item("Contact_Person_Name")
                .Relationship = rdr.Item("Relationship")
                .Contact_address1 = rdr.Item("Contact_address1")
                .Contact_address2 = rdr.Item("Contact_address2")
                .Contact_home_tel1 = rdr.Item("Contact_home_tel1")
                .Contact_home_tel2 = rdr.Item("Contact_home_tel2")
                .Emp_Blood_Group = rdr.Item("Emp_Blood_Group")
                .Employment_Type_code = rdr.Item("Employment_Type_code")
                .Emp_category = rdr.Item("Emp_category")
                .Emp_Leave_category = rdr.Item("Emp_Leave_category")
                .Emp_Payroll_category = rdr.Item("Emp_Payroll_category")
                .Shift_code = rdr.Item("Shift_code")
                .Desig_code = rdr.Item("Desig_code")
                .Dept_code = rdr.Item("Dept_code")
                .Cost_Centre_code = rdr.Item("Cost_Centre_code")
                .Section_code = rdr.Item("Section_code")
                .Grade_code = rdr.Item("Grade_code")
                .Edu_code = rdr.Item("Edu_code")
                .Loc_code = rdr.Item("Loc_code")
                .Transport_code = rdr.Item("Transport_code")
                .Religion_Code = rdr.Item("Religion_Code")
                .Supervisor_Code = rdr.Item("Supervisor_Code")
            End With

            Return Employee
        Catch ex As Exception
            Throw ex
        Finally
            rdr.Close()
            cn.Close()
            rdr = Nothing
            cn = Nothing

        End Try
    End Function
    Public Shared Function getMasterAllEmployeeList() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterAllEmployeesList", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function
    Public Shared Function getContractEmployess_List() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_ContractToPermenant_List", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function
    Public Shared Function getMasterEmployee_List_HistoryLeaves() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_List_Histroy_Leaves", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function
    Public Shared Function getMasterEmployee_List_History_Confirmations() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_History_Confrimations_PER_MasterEmployees_List_History_Confrimations", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function
    Public Shared Function getMasterEmployee_List_History_Increments() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_History_Confrimations_PER_MasterEmployees_List_History_Increments", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function
    Public Shared Function getMasterEmployee_List_History_Transfers() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_History_Confrimations_PER_MasterEmployees_List_History_transfers", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function
    Public Shared Function getMasterEmployee_List_History_Appointments() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("sp_Histroy_Appointments_List", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function
    Public Shared Function getMasterEmployee_List_History_Promotions() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_History_Confrimations_PER_MasterEmployees_List_History_Promotions", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function
    Public Shared Function getMasterEmployee_List_Loan() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_Loan_MasterEmployees_List", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function

    Public Shared Function getMasterEmployee_Search_Married(ByVal SType As Char, ByVal Val As String) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_Search_Married", cn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@User_Code", System.Web.HttpContext.Current.Session("Emp_Code"))

        Dim SearchType As New SqlParameter("@SearchType", SqlDbType.Char, 1, ParameterDirection.Input)
        SearchType.Value = SType
        cmd.Parameters.Add(SearchType)

        Dim Value As New SqlParameter("@Value", SqlDbType.VarChar, 100, ParameterDirection.Input)
        Value.Value = Val
        cmd.Parameters.Add(Value)

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function

    Public Shared Function getMasterEmployee_List_Married() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_List_Married", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@User_Code", System.Web.HttpContext.Current.Session("Emp_Code"))

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function

    Public Shared Function getMasterEmployee_List_ConfirmFlagNo() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_ListConfirmFlagNo", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@User_Code", System.Web.HttpContext.Current.Session("Emp_Code"))
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function

    Public Shared Function getMasterEmployee_List_Marriage(ByVal Status As Char) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_List_Marriage", cn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@User_Code", System.Web.HttpContext.Current.Session("Emp_Code"))

        Dim MaritalStatus As New SqlParameter("@Marital_Status", SqlDbType.Char, 1, ParameterDirection.Input)
        MaritalStatus.Value = Status
        cmd.Parameters.Add(MaritalStatus)

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function

    Public Shared Function getMasterEmployee_List_Resign() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_List_Resign", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_All_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function

    Public Shared Function getMasterEmployee_Combo() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_Combo", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@User_Code", System.Web.HttpContext.Current.Session("Emp_Code"))
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function

    Public Shared Function getPostionSupervisor_Combo() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_Postion_Supervisor_Combo", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@User_Code", System.Web.HttpContext.Current.Session("Emp_Code"))
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function

    Public Shared Function getMasterEmployee_Search_Marriage(ByVal SType As Char, ByVal Val As String, ByVal Status As Char) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_Search_Marriage", cn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@User_Code", System.Web.HttpContext.Current.Session("Emp_Code"))

        Dim SearchType As New SqlParameter("@SearchType", SqlDbType.Char, 1, ParameterDirection.Input)
        SearchType.Value = SType
        cmd.Parameters.Add(SearchType)

        Dim Value As New SqlParameter("@Value", SqlDbType.VarChar, 100, ParameterDirection.Input)
        Value.Value = Val
        cmd.Parameters.Add(Value)

        Dim MaritalStatus As New SqlParameter("@Marital_Status", SqlDbType.Char, 1, ParameterDirection.Input)
        MaritalStatus.Value = Status
        cmd.Parameters.Add(MaritalStatus)


        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function

    Public Shared Function getMasterEmployee_Search(ByVal SType As Char, ByVal Val As String) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_Search", cn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@User_Code", System.Web.HttpContext.Current.Session("Emp_Code"))

        Dim SearchType As New SqlParameter("@SearchType", SqlDbType.Char, 1, ParameterDirection.Input)
        SearchType.Value = SType
        cmd.Parameters.Add(SearchType)

        Dim Value As New SqlParameter("@Value", SqlDbType.VarChar, 100, ParameterDirection.Input)
        Value.Value = Val
        cmd.Parameters.Add(Value)

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function


    Public Shared Function getMasterEmployeeActive_Search(ByVal SType As Char, ByVal Val As String) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployeesActive_Search", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim SearchType As New SqlParameter("@SearchType", SqlDbType.Char, 1, ParameterDirection.Input)
        SearchType.Value = SType
        cmd.Parameters.Add(SearchType)

        Dim Value As New SqlParameter("@Value", SqlDbType.VarChar, 100, ParameterDirection.Input)
        Value.Value = Val
        cmd.Parameters.Add(Value)

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function


    Public Shared Function getMasterEmployee_SearchWithPayrollCategory(ByVal SType As Char, ByVal Val As String, ByVal PayrollCategory As Integer) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_SearchWithPayrollCategory", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim SearchType As New SqlParameter("@SearchType", SqlDbType.Char, 1, ParameterDirection.Input)
        SearchType.Value = SType
        cmd.Parameters.Add(SearchType)

        Dim Value As New SqlParameter("@Value", SqlDbType.VarChar, 100, ParameterDirection.Input)
        Value.Value = Val
        cmd.Parameters.Add(Value)

        cmd.Parameters.AddWithValue("@PayrollCategory", PayrollCategory)

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function

    Public Shared Function getMasterAllEmployee_Search(ByVal SType As Char, ByVal Val As String) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterAllEmployees_Search", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim SearchType As New SqlParameter("@SearchType", SqlDbType.Char, 1, ParameterDirection.Input)
        SearchType.Value = SType
        cmd.Parameters.Add(SearchType)

        Dim Value As New SqlParameter("@Value", SqlDbType.VarChar, 100, ParameterDirection.Input)
        Value.Value = Val
        cmd.Parameters.Add(Value)

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function

    Public Shared Function getMasterEmployee_Search_UserName(ByVal loginID As Integer, ByVal SType As Char, ByVal Val As String) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_List_UserName", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim login_id As New SqlParameter("@login_id", SqlDbType.Int, ParameterDirection.Input)
        login_id.Value = loginID
        cmd.Parameters.Add(login_id)

        Dim SearchType As New SqlParameter("@SearchType", SqlDbType.Char, 1, ParameterDirection.Input)
        SearchType.Value = SType
        cmd.Parameters.Add(SearchType)

        Dim Value As New SqlParameter("@Value", SqlDbType.VarChar, 100, ParameterDirection.Input)
        Value.Value = Val
        cmd.Parameters.Add(Value)

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function
    Public Shared Function getMasterEmployee_Search_History(ByVal SType As Char, ByVal Val As String) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_SearchHistory_Laeve", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim SearchType As New SqlParameter("@SearchType", SqlDbType.Char, 1, ParameterDirection.Input)
        SearchType.Value = SType
        cmd.Parameters.Add(SearchType)

        Dim Value As New SqlParameter("@Value", SqlDbType.VarChar, 100, ParameterDirection.Input)
        Value.Value = Val
        cmd.Parameters.Add(Value)

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function

    Public Shared Function getLoan_MasterEmployee_Search(ByVal SType As Char, ByVal Val As String) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_Loan_MasterEmployees_Search", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim SearchType As New SqlParameter("@SearchType", SqlDbType.Char, 1, ParameterDirection.Input)
        SearchType.Value = SType
        cmd.Parameters.Add(SearchType)

        Dim Value As New SqlParameter("@Value", SqlDbType.VarChar, 100, ParameterDirection.Input)
        Value.Value = Val
        cmd.Parameters.Add(Value)

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function
    Public Shared Function getMasterEmployee_Search_ConfirmFlagNo(ByVal SType As Char, ByVal Val As String) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_Search_ConfirmFlagNo", cn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@User_Code", System.Web.HttpContext.Current.Session("Emp_Code"))

        Dim SearchType As New SqlParameter("@SearchType", SqlDbType.Char, 1, ParameterDirection.Input)
        SearchType.Value = SType
        cmd.Parameters.Add(SearchType)

        Dim Value As New SqlParameter("@Value", SqlDbType.VarChar, 100, ParameterDirection.Input)
        Value.Value = Val
        cmd.Parameters.Add(Value)



        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function
    Public Shared Function getMasterEmployee_Search_ConfirmFlagNo_History_Confirmations(ByVal SType As Char, ByVal Val As String) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_History_Confirmations_MasterEmployees_Search_ConfirmFlagNo", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim SearchType As New SqlParameter("@SearchType", SqlDbType.Char, 1, ParameterDirection.Input)
        SearchType.Value = SType
        cmd.Parameters.Add(SearchType)

        Dim Value As New SqlParameter("@Value", SqlDbType.VarChar, 100, ParameterDirection.Input)
        Value.Value = Val
        cmd.Parameters.Add(Value)

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function
    Public Shared Function getMasterEmployee_Search_History_Increments(ByVal SType As Char, ByVal Val As String) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_History_Increments_MasterEmployees_Search", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim SearchType As New SqlParameter("@SearchType", SqlDbType.Char, 1, ParameterDirection.Input)
        SearchType.Value = SType
        cmd.Parameters.Add(SearchType)

        Dim Value As New SqlParameter("@Value", SqlDbType.VarChar, 100, ParameterDirection.Input)
        Value.Value = Val
        cmd.Parameters.Add(Value)

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function
    Public Shared Function getMasterEmployee_Search_History_Transfer(ByVal SType As Char, ByVal Val As String) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_History_Transfers_MasterEmployees_Search", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim SearchType As New SqlParameter("@SearchType", SqlDbType.Char, 1, ParameterDirection.Input)
        SearchType.Value = SType
        cmd.Parameters.Add(SearchType)

        Dim Value As New SqlParameter("@Value", SqlDbType.VarChar, 100, ParameterDirection.Input)
        Value.Value = Val
        cmd.Parameters.Add(Value)

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function
    Public Shared Function getMasterEmployee_Search_History_Appointments(ByVal SType As Char, ByVal Val As String) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_History_Appointments_MasterEmployees_Search", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim SearchType As New SqlParameter("@SearchType", SqlDbType.Char, 1, ParameterDirection.Input)
        SearchType.Value = SType
        cmd.Parameters.Add(SearchType)

        Dim Value As New SqlParameter("@Value", SqlDbType.VarChar, 100, ParameterDirection.Input)
        Value.Value = Val
        cmd.Parameters.Add(Value)

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function
    Public Shared Function getMasterEmployee_Search_History_Promotions(ByVal SType As Char, ByVal Val As String) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_History_Promotions_MasterEmployees_Search", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim SearchType As New SqlParameter("@SearchType", SqlDbType.Char, 1, ParameterDirection.Input)
        SearchType.Value = SType
        cmd.Parameters.Add(SearchType)

        Dim Value As New SqlParameter("@Value", SqlDbType.VarChar, 100, ParameterDirection.Input)
        Value.Value = Val
        cmd.Parameters.Add(Value)

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function

    Public Shared Function getMasterEmployee_Search_Resign(ByVal SType As Char, ByVal Val As String) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_Search_Resign", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim SearchType As New SqlParameter("@SearchType", SqlDbType.Char, 1, ParameterDirection.Input)
        SearchType.Value = SType
        cmd.Parameters.Add(SearchType)

        Dim Value As New SqlParameter("@Value", SqlDbType.VarChar, 100, ParameterDirection.Input)
        Value.Value = Val
        cmd.Parameters.Add(Value)

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_All_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function

    Public Shared Function getMasterEmployee_Search_Management(ByVal SType As Char, ByVal Val As String) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_Search_Management", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim SearchType As New SqlParameter("@SearchType", SqlDbType.Char, 1, ParameterDirection.Input)
        SearchType.Value = SType
        cmd.Parameters.Add(SearchType)

        Dim Value As New SqlParameter("@Value", SqlDbType.VarChar, 100, ParameterDirection.Input)
        Value.Value = Val
        cmd.Parameters.Add(Value)

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function
    Public Shared Function UpdateMasterEmployees(ByVal MEmp As MasterEmployeesInfo) As Boolean


        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_Update", cn)
        cmd.CommandType = CommandType.StoredProcedure

        ' creating parameters
        Dim Empcode As New SqlParameter("@Emp_code", SqlDbType.Int, ParameterDirection.Input)
        Empcode.Value = MEmp.Emp_code
        cmd.Parameters.Add(Empcode)

        Dim Empsexcode As New SqlParameter("@Emp_sex_code", SqlDbType.VarChar, 1, ParameterDirection.Input)
        Empsexcode.Value = MEmp.Emp_sex_code
        cmd.Parameters.Add(Empsexcode)

        Dim Empmaritalstatus As New SqlParameter("@Emp_marital_status", SqlDbType.VarChar, 1, ParameterDirection.Input)
        Empmaritalstatus.Value = MEmp.Emp_marital_status
        cmd.Parameters.Add(Empmaritalstatus)

        Dim Salutation_Code As New SqlParameter("@Salutation_Code", SqlDbType.Int, 4, ParameterDirection.Input)
        Salutation_Code.Value = MEmp.Salutation_Code
        cmd.Parameters.Add(Salutation_Code)

        Dim Empname As New SqlParameter("@Emp_name", SqlDbType.VarChar, 100, ParameterDirection.Input)
        Empname.Value = MEmp.Emp_name
        cmd.Parameters.Add(Empname)

        Dim EmpFathername As New SqlParameter("@Emp_Father_name", SqlDbType.VarChar, 100, ParameterDirection.Input)
        EmpFathername.Value = MEmp.Emp_Father_name
        cmd.Parameters.Add(EmpFathername)

        Dim Empappointmentdate As New SqlParameter("@Emp_appointment_date", SqlDbType.DateTime, ParameterDirection.Input)
        Empappointmentdate.Value = MEmp.Emp_appointment_date
        cmd.Parameters.Add(Empappointmentdate)

        Dim EmpConfirmdate As New SqlParameter("@Emp_Confirm_date", SqlDbType.DateTime, ParameterDirection.Input)
        EmpConfirmdate.Value = MEmp.Emp_Confirm_date
        cmd.Parameters.Add(EmpConfirmdate)

        Dim Emp_Current_address_line1 As New SqlParameter("@Emp_Current_address_line1", SqlDbType.VarChar, 200, ParameterDirection.Input)
        Emp_Current_address_line1.Value = MEmp.Emp_Current_address_line1
        cmd.Parameters.Add(Emp_Current_address_line1)

        Dim Emp_Current_address_line2 As New SqlParameter("@Emp_Current_address_line2", SqlDbType.VarChar, 200, ParameterDirection.Input)
        Emp_Current_address_line2.Value = MEmp.Emp_Current_address_line2
        cmd.Parameters.Add(Emp_Current_address_line2)

        Dim Emp_Permanant_address_line1 As New SqlParameter("@Emp_Permanant_address_line1", SqlDbType.VarChar, 200, ParameterDirection.Input)
        Emp_Permanant_address_line1.Value = MEmp.Emp_Permanant_address_line1
        cmd.Parameters.Add(Emp_Permanant_address_line1)

        Dim Emp_Permanant_address_line2 As New SqlParameter("@Emp_Permanant_address_line2", SqlDbType.VarChar, 200, ParameterDirection.Input)
        Emp_Permanant_address_line2.Value = MEmp.Emp_Permanant_address_line2
        cmd.Parameters.Add(Emp_Permanant_address_line2)

        Dim Address_City_Code As New SqlParameter("@Address_City_Code", SqlDbType.Int, ParameterDirection.Input)
        Address_City_Code.Value = MEmp.Address_City_Code
        cmd.Parameters.Add(Address_City_Code)

        Dim Emphometel1 As New SqlParameter("@Emp_home_tel1", SqlDbType.VarChar, 30, ParameterDirection.Input)
        Emphometel1.Value = MEmp.Emp_home_tel1
        cmd.Parameters.Add(Emphometel1)

        Dim Emphometel2 As New SqlParameter("@Emp_home_tel2", SqlDbType.VarChar, 15, ParameterDirection.Input)
        Emphometel2.Value = MEmp.Emp_home_tel2
        cmd.Parameters.Add(Emphometel2)

        Dim Empofficetel1 As New SqlParameter("@Emp_office_tel1", SqlDbType.VarChar, 15, ParameterDirection.Input)
        Empofficetel1.Value = MEmp.Emp_office_tel1
        cmd.Parameters.Add(Empofficetel1)

        Dim Empofficetel2 As New SqlParameter("@Emp_office_tel2", SqlDbType.VarChar, 15, ParameterDirection.Input)
        Empofficetel2.Value = MEmp.Emp_office_tel2
        cmd.Parameters.Add(Empofficetel2)

        Dim EmpmobileNo As New SqlParameter("@Emp_mobile_No", SqlDbType.VarChar, 20, ParameterDirection.Input)
        EmpmobileNo.Value = MEmp.Emp_mobile_No
        cmd.Parameters.Add(EmpmobileNo)

        Dim Official_Mobile_No As New SqlParameter("@Official_Mobile_No", SqlDbType.VarChar, 30, ParameterDirection.Input)
        Official_Mobile_No.Value = MEmp.Official_Mobile_No
        cmd.Parameters.Add(Official_Mobile_No)

        Dim Empemail As New SqlParameter("@Emp_email", SqlDbType.VarChar, 70, ParameterDirection.Input)
        Empemail.Value = MEmp.Emp_email
        cmd.Parameters.Add(Empemail)

        Dim Empnicno As New SqlParameter("@Emp_nic_no", SqlDbType.VarChar, 30, ParameterDirection.Input)
        Empnicno.Value = MEmp.Emp_nic_no
        cmd.Parameters.Add(Empnicno)


        Dim Empnicissuedate As New SqlParameter("@Emp_NIC_Issue_date", SqlDbType.DateTime, ParameterDirection.Input)
        Empnicissuedate.Value = MEmp.Emp_NIC_Issue_date
        cmd.Parameters.Add(Empnicissuedate)

        Dim Empnicexpirydate As New SqlParameter("@Emp_NIC_Expiry_date", SqlDbType.DateTime, ParameterDirection.Input)
        Empnicexpirydate.Value = MEmp.Emp_NIC_Expiry_date
        cmd.Parameters.Add(Empnicexpirydate)

        Dim Empretirmentage As New SqlParameter("@Emp_Retirement_age", SqlDbType.Int, ParameterDirection.Input)
        Empretirmentage.Value = MEmp.Emp_Retirement_age
        cmd.Parameters.Add(Empretirmentage)

        Dim Empntnno As New SqlParameter("@Emp_ntn_no", SqlDbType.VarChar, 15, ParameterDirection.Input)
        Empntnno.Value = MEmp.Emp_ntn_no
        cmd.Parameters.Add(Empntnno)


        Dim Empbirthdate As New SqlParameter("@Emp_birth_date", SqlDbType.DateTime, ParameterDirection.Input)
        Empbirthdate.Value = MEmp.Emp_birth_date
        cmd.Parameters.Add(Empbirthdate)

        Dim VehicleRegistrationNumber As New SqlParameter("@Vehicle_Registration_Number", SqlDbType.VarChar, 100, ParameterDirection.Input)
        VehicleRegistrationNumber.Value = MEmp.Vehicle_Registration_Number
        cmd.Parameters.Add(VehicleRegistrationNumber)

        Dim ContactPersonName As New SqlParameter("@Contact_Person_Name", SqlDbType.VarChar, 30, ParameterDirection.Input)
        ContactPersonName.Value = MEmp.Contact_Person_Name
        cmd.Parameters.Add(ContactPersonName)

        Dim Relationship As New SqlParameter("@Relationship", SqlDbType.VarChar, 15, ParameterDirection.Input)
        Relationship.Value = MEmp.Relationship
        cmd.Parameters.Add(Relationship)

        Dim Contactaddress1 As New SqlParameter("@Contact_address1", SqlDbType.VarChar, 40, ParameterDirection.Input)
        Contactaddress1.Value = MEmp.Contact_address1
        cmd.Parameters.Add(Contactaddress1)

        Dim Contactaddress2 As New SqlParameter("@Contact_address2", SqlDbType.VarChar, 40, ParameterDirection.Input)
        Contactaddress2.Value = MEmp.Contact_address2
        cmd.Parameters.Add(Contactaddress2)

        Dim Contacthometel1 As New SqlParameter("@Contact_home_tel1", SqlDbType.VarChar, 20, ParameterDirection.Input)
        Contacthometel1.Value = MEmp.Contact_home_tel1
        cmd.Parameters.Add(Contacthometel1)

        Dim Contacthometel2 As New SqlParameter("@Contact_home_tel2", SqlDbType.VarChar, 20, ParameterDirection.Input)
        Contacthometel2.Value = MEmp.Contact_home_tel2
        cmd.Parameters.Add(Contacthometel2)

        Dim EmpBloodGroup As New SqlParameter("@Emp_Blood_Group", SqlDbType.VarChar, 4, ParameterDirection.Input)
        EmpBloodGroup.Value = MEmp.Emp_Blood_Group
        cmd.Parameters.Add(EmpBloodGroup)

        Dim EmploymentTypecode As New SqlParameter("@Employment_Type_code", SqlDbType.Int, ParameterDirection.Input)
        EmploymentTypecode.Value = MEmp.Employment_Type_code
        cmd.Parameters.Add(EmploymentTypecode)

        Dim Empcategory As New SqlParameter("@Emp_category", SqlDbType.Int, ParameterDirection.Input)
        Empcategory.Value = MEmp.Emp_category
        cmd.Parameters.Add(Empcategory)

        Dim EmpLeavecategory As New SqlParameter("@Emp_Leave_category", SqlDbType.Int, ParameterDirection.Input)
        EmpLeavecategory.Value = MEmp.Emp_Leave_category
        cmd.Parameters.Add(EmpLeavecategory)

        Dim EmpPayrollcategory As New SqlParameter("@Emp_Payroll_category", SqlDbType.Int, ParameterDirection.Input)
        EmpPayrollcategory.Value = MEmp.Emp_Payroll_category
        cmd.Parameters.Add(EmpPayrollcategory)

        Dim Shiftcode As New SqlParameter("@Shift_code", SqlDbType.Int, ParameterDirection.Input)
        Shiftcode.Value = MEmp.Shift_code
        cmd.Parameters.Add(Shiftcode)

        Dim Desigcode As New SqlParameter("@Desig_code", SqlDbType.Int, ParameterDirection.Input)
        Desigcode.Value = MEmp.Desig_code
        cmd.Parameters.Add(Desigcode)

        Dim CostCentrecode As New SqlParameter("@Cost_Centre_code", SqlDbType.Int, ParameterDirection.Input)
        CostCentrecode.Value = MEmp.Cost_Centre_code
        cmd.Parameters.Add(CostCentrecode)

        Dim Sectioncode As New SqlParameter("@Section_code", SqlDbType.Int, ParameterDirection.Input)
        Sectioncode.Value = MEmp.Section_code
        cmd.Parameters.Add(Sectioncode)

        Dim Gradecode As New SqlParameter("@Grade_code", SqlDbType.Int, ParameterDirection.Input)
        Gradecode.Value = MEmp.Grade_code
        cmd.Parameters.Add(Gradecode)

        Dim Educode As New SqlParameter("@Edu_code", SqlDbType.Int, ParameterDirection.Input)
        Educode.Value = MEmp.Edu_code
        cmd.Parameters.Add(Educode)

        Dim Loccode As New SqlParameter("@Loc_code", SqlDbType.Int, ParameterDirection.Input)
        Loccode.Value = MEmp.Loc_code
        cmd.Parameters.Add(Loccode)


        Dim ReligionCode As New SqlParameter("@Religion_Code", SqlDbType.Int, ParameterDirection.Input)
        ReligionCode.Value = MEmp.Religion_Code
        cmd.Parameters.Add(ReligionCode)

        Dim SupervisorCode As New SqlParameter("@Supervisor_Code", SqlDbType.Int, ParameterDirection.Input)
        SupervisorCode.Value = MEmp.Supervisor_Code
        cmd.Parameters.Add(SupervisorCode)


        Dim ProbPeriods As New SqlParameter("@ProbPeriod", SqlDbType.Int, ParameterDirection.Input)
        ProbPeriods.Value = MEmp.ProbPeriod
        cmd.Parameters.Add(ProbPeriods)

        Dim Roster_Group_Code As New SqlParameter("@Roster_Group_Code", SqlDbType.Int, ParameterDirection.Input)
        Roster_Group_Code.Value = MEmp.Roster_Group_Code
        cmd.Parameters.Add(Roster_Group_Code)

        Dim Nationality As New SqlParameter("@Nationality", SqlDbType.VarChar, 50, ParameterDirection.Input)
        Nationality.Value = MEmp.Nationality
        cmd.Parameters.Add(Nationality)

        Dim card_no As New SqlParameter("@card_no", SqlDbType.VarChar, 50, ParameterDirection.Input)
        card_no.Value = MEmp.card_no
        cmd.Parameters.Add(card_no)
        Dim Sharia_Flag As New SqlParameter("@Sharia_Flag", SqlDbType.VarChar, 1, ParameterDirection.Input)
        Sharia_Flag.Value = MEmp.Sharia_Flag
        cmd.Parameters.Add(Sharia_Flag)

        Dim Profit_Willing_Flag As New SqlParameter("@Profit_Willing_Flag", SqlDbType.VarChar, 1, ParameterDirection.Input)
        Profit_Willing_Flag.Value = MEmp.Profit_Willing_Flag
        cmd.Parameters.Add(Profit_Willing_Flag)

        cmd.Parameters.AddWithValue("@UserCode", System.Web.HttpContext.Current.Session("Emp_code"))


        Try
            cn.Open()
            Dim result As Integer
            result = cmd.ExecuteNonQuery()
            If result > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        Finally
            cn.Close()
            cn = Nothing

        End Try

    End Function

    Public Shared Function UpdateHistoryAppointment(ByVal MEmp As MasterEmployeesInfo) As Boolean


        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_historyappointment_Update", cn)
        cmd.CommandType = CommandType.StoredProcedure

        ' creating parameters
        Dim Empcode As New SqlParameter("@Emp_code", SqlDbType.Int, ParameterDirection.Input)
        Empcode.Value = MEmp.Emp_code
        cmd.Parameters.Add(Empcode)

        Dim CompanyEmployeeFlag As New SqlParameter("@Company_Employee_Flag", SqlDbType.VarChar, 1, ParameterDirection.Input)
        CompanyEmployeeFlag.Value = MEmp.Company_Employee_Flag
        cmd.Parameters.Add(CompanyEmployeeFlag)

        Dim Empsexcode As New SqlParameter("@Emp_sex_code", SqlDbType.VarChar, 1, ParameterDirection.Input)
        Empsexcode.Value = MEmp.Emp_sex_code
        cmd.Parameters.Add(Empsexcode)

        Dim Empmaritalstatus As New SqlParameter("@Emp_marital_status", SqlDbType.VarChar, 1, ParameterDirection.Input)
        Empmaritalstatus.Value = MEmp.Emp_marital_status
        cmd.Parameters.Add(Empmaritalstatus)

        Dim Empname As New SqlParameter("@Emp_name", SqlDbType.VarChar, 50, ParameterDirection.Input)
        Empname.Value = MEmp.Emp_name
        cmd.Parameters.Add(Empname)

        Dim EmpFathername As New SqlParameter("@Emp_Father_name", SqlDbType.VarChar, 50, ParameterDirection.Input)
        EmpFathername.Value = MEmp.Emp_Father_name
        cmd.Parameters.Add(EmpFathername)

        Dim Empappointmentdate As New SqlParameter("@Emp_appointment_date", SqlDbType.DateTime, ParameterDirection.Input)
        Empappointmentdate.Value = MEmp.Emp_appointment_date
        cmd.Parameters.Add(Empappointmentdate)

        Dim EmpConfirmdate As New SqlParameter("@Emp_Confirm_date", SqlDbType.DateTime, ParameterDirection.Input)
        EmpConfirmdate.Value = MEmp.Emp_Confirm_date
        cmd.Parameters.Add(EmpConfirmdate)

        Dim Empaddressline1 As New SqlParameter("@Emp_address_line1", SqlDbType.VarChar, 200, ParameterDirection.Input)
        Empaddressline1.Value = MEmp.Emp_address_line1
        cmd.Parameters.Add(Empaddressline1)

        Dim Empaddressline2 As New SqlParameter("@Emp_address_line2", SqlDbType.VarChar, 60, ParameterDirection.Input)
        Empaddressline2.Value = MEmp.Emp_address_line2
        cmd.Parameters.Add(Empaddressline2)

        Dim Emphometel1 As New SqlParameter("@Emp_home_tel1", SqlDbType.VarChar, 30, ParameterDirection.Input)
        Emphometel1.Value = MEmp.Emp_home_tel1
        cmd.Parameters.Add(Emphometel1)

        Dim Emphometel2 As New SqlParameter("@Emp_home_tel2", SqlDbType.VarChar, 15, ParameterDirection.Input)
        Emphometel2.Value = MEmp.Emp_home_tel2
        cmd.Parameters.Add(Emphometel2)

        Dim Empofficetel1 As New SqlParameter("@Emp_office_tel1", SqlDbType.VarChar, 15, ParameterDirection.Input)
        Empofficetel1.Value = MEmp.Emp_office_tel1
        cmd.Parameters.Add(Empofficetel1)

        Dim Empofficetel2 As New SqlParameter("@Emp_office_tel2", SqlDbType.VarChar, 15, ParameterDirection.Input)
        Empofficetel2.Value = MEmp.Emp_office_tel2
        cmd.Parameters.Add(Empofficetel2)

        Dim EmpmobileNo As New SqlParameter("@Emp_mobile_No", SqlDbType.VarChar, 20, ParameterDirection.Input)
        EmpmobileNo.Value = MEmp.Emp_mobile_No
        cmd.Parameters.Add(EmpmobileNo)

        Dim Empemail As New SqlParameter("@Emp_email", SqlDbType.VarChar, 70, ParameterDirection.Input)
        Empemail.Value = MEmp.Emp_email
        cmd.Parameters.Add(Empemail)

        Dim Empnicno As New SqlParameter("@Emp_nic_no", SqlDbType.VarChar, 30, ParameterDirection.Input)
        Empnicno.Value = MEmp.Emp_nic_no
        cmd.Parameters.Add(Empnicno)

        Dim Empntnno As New SqlParameter("@Emp_ntn_no", SqlDbType.VarChar, 15, ParameterDirection.Input)
        Empntnno.Value = MEmp.Emp_ntn_no
        cmd.Parameters.Add(Empntnno)

        Dim Empbirthdate As New SqlParameter("@Emp_birth_date", SqlDbType.DateTime, ParameterDirection.Input)
        Empbirthdate.Value = MEmp.Emp_birth_date
        cmd.Parameters.Add(Empbirthdate)

        Dim VehicleRegistrationNumber As New SqlParameter("@Vehicle_Registration_Number", SqlDbType.VarChar, 10, ParameterDirection.Input)
        VehicleRegistrationNumber.Value = MEmp.Vehicle_Registration_Number
        cmd.Parameters.Add(VehicleRegistrationNumber)

        Dim ContactPersonName As New SqlParameter("@Contact_Person_Name", SqlDbType.VarChar, 30, ParameterDirection.Input)
        ContactPersonName.Value = MEmp.Contact_Person_Name
        cmd.Parameters.Add(ContactPersonName)

        Dim Relationship As New SqlParameter("@Relationship", SqlDbType.VarChar, 15, ParameterDirection.Input)
        Relationship.Value = MEmp.Relationship
        cmd.Parameters.Add(Relationship)

        Dim Contactaddress1 As New SqlParameter("@Contact_address1", SqlDbType.VarChar, 40, ParameterDirection.Input)
        Contactaddress1.Value = MEmp.Contact_address1
        cmd.Parameters.Add(Contactaddress1)

        Dim Contactaddress2 As New SqlParameter("@Contact_address2", SqlDbType.VarChar, 40, ParameterDirection.Input)
        Contactaddress2.Value = MEmp.Contact_address2
        cmd.Parameters.Add(Contactaddress2)

        Dim Contacthometel1 As New SqlParameter("@Contact_home_tel1", SqlDbType.VarChar, 20, ParameterDirection.Input)
        Contacthometel1.Value = MEmp.Contact_home_tel1
        cmd.Parameters.Add(Contacthometel1)

        Dim Contacthometel2 As New SqlParameter("@Contact_home_tel2", SqlDbType.VarChar, 20, ParameterDirection.Input)
        Contacthometel2.Value = MEmp.Contact_home_tel2
        cmd.Parameters.Add(Contacthometel2)

        Dim EmpBloodGroup As New SqlParameter("@Emp_Blood_Group", SqlDbType.VarChar, 4, ParameterDirection.Input)
        EmpBloodGroup.Value = MEmp.Emp_Blood_Group
        cmd.Parameters.Add(EmpBloodGroup)

        Dim EmploymentTypecode As New SqlParameter("@Employment_Type_code", SqlDbType.Int, ParameterDirection.Input)
        EmploymentTypecode.Value = MEmp.Employment_Type_code
        cmd.Parameters.Add(EmploymentTypecode)

        Dim Empcategory As New SqlParameter("@Emp_category", SqlDbType.Int, ParameterDirection.Input)
        Empcategory.Value = MEmp.Emp_category
        cmd.Parameters.Add(Empcategory)

        Dim EmpLeavecategory As New SqlParameter("@Emp_Leave_category", SqlDbType.Int, ParameterDirection.Input)
        EmpLeavecategory.Value = MEmp.Emp_Leave_category
        cmd.Parameters.Add(EmpLeavecategory)

        Dim EmpPayrollcategory As New SqlParameter("@Emp_Payroll_category", SqlDbType.Int, ParameterDirection.Input)
        EmpPayrollcategory.Value = MEmp.Emp_Payroll_category
        cmd.Parameters.Add(EmpPayrollcategory)

        Dim Shiftcode As New SqlParameter("@Shift_code", SqlDbType.Int, ParameterDirection.Input)
        Shiftcode.Value = MEmp.Shift_code
        cmd.Parameters.Add(Shiftcode)

        Dim Desigcode As New SqlParameter("@Desig_code", SqlDbType.Int, ParameterDirection.Input)
        Desigcode.Value = MEmp.Desig_code
        cmd.Parameters.Add(Desigcode)

        Dim CostCentrecode As New SqlParameter("@Cost_Centre_code", SqlDbType.Int, ParameterDirection.Input)
        CostCentrecode.Value = MEmp.Cost_Centre_code
        cmd.Parameters.Add(CostCentrecode)

        Dim Sectioncode As New SqlParameter("@Section_code", SqlDbType.Int, ParameterDirection.Input)
        Sectioncode.Value = MEmp.Section_code
        cmd.Parameters.Add(Sectioncode)

        Dim Gradecode As New SqlParameter("@Grade_code", SqlDbType.Int, ParameterDirection.Input)
        Gradecode.Value = MEmp.Grade_code
        cmd.Parameters.Add(Gradecode)

        Dim Educode As New SqlParameter("@Edu_code", SqlDbType.Int, ParameterDirection.Input)
        Educode.Value = MEmp.Edu_code
        cmd.Parameters.Add(Educode)

        Dim Loccode As New SqlParameter("@Loc_code", SqlDbType.Int, ParameterDirection.Input)
        Loccode.Value = MEmp.Loc_code
        cmd.Parameters.Add(Loccode)

        Dim Transportcode As New SqlParameter("@Transport_code", SqlDbType.Int, ParameterDirection.Input)
        Transportcode.Value = MEmp.Transport_code
        cmd.Parameters.Add(Transportcode)

        Dim ReligionCode As New SqlParameter("@Religion_Code", SqlDbType.Int, ParameterDirection.Input)
        ReligionCode.Value = MEmp.Religion_Code
        cmd.Parameters.Add(ReligionCode)

        Dim SupervisorCode As New SqlParameter("@Supervisor_Code", SqlDbType.Int, ParameterDirection.Input)
        SupervisorCode.Value = MEmp.Supervisor_Code
        cmd.Parameters.Add(SupervisorCode)


        Try
            cn.Open()
            Dim result As Integer
            result = cmd.ExecuteNonQuery()
            If result > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        Finally
            cn.Close()
            cn = Nothing

        End Try

    End Function

    Public Shared Function getMasterEmployee_List_Management() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployee_List_Management", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function

    Public Shared Function getMasterEmployee_List_NON_Management() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_List_NON_Management", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function

    Public Shared Function getEmployeeLeavePlan(ByVal emp_code As Integer) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_getEmployeeLeavePlan", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@emp_code", emp_code)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try


    End Function







    Public Shared Function SaveContractEmployeeRenewelDelete(ByVal ID As Integer) As DataSet


        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_saveContractEmployeeRenewelDelete", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@ID", ID)
        cmd.Parameters.AddWithValue("@Posted_by", System.Web.HttpContext.Current.Session("Emp_code"))


        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try


    End Function

    Public Shared Function SaveContractEmployeeRenewelUpdate(ByVal ID As Integer, ByVal Start_Date As Date, ByVal End_Date As Date) As DataSet


        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_saveContractEmployeeRenewelUpdate", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@ID", ID)
        cmd.Parameters.AddWithValue("@start_date", Start_Date)
        cmd.Parameters.AddWithValue("@end_date", End_Date)
        cmd.Parameters.AddWithValue("@Posted_by", System.Web.HttpContext.Current.Session("Emp_code"))


        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try


    End Function

    Public Shared Function SaveContractEmployeeRenewelAdd(ByVal emp_code As Integer, ByVal Start_Date As Date, ByVal End_Date As Date) As DataSet


        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_saveContractEmployeeRenewelAdd", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@emp_code", emp_code)
        cmd.Parameters.AddWithValue("@start_date", Start_Date)
        cmd.Parameters.AddWithValue("@end_date", End_Date)
        cmd.Parameters.AddWithValue("@Posted_by", System.Web.HttpContext.Current.Session("Emp_code"))


        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try


    End Function
    Public Shared Function SaveContractEmployeeRenewelProcess(ByVal ID As Integer) As DataSet


        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_saveContractEmployeeRenewelProcess", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@ID", ID)
        cmd.Parameters.AddWithValue("@Posted_by", System.Web.HttpContext.Current.Session("Emp_code"))


        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try


    End Function

    Public Shared Function getEmployeeMedicalPlan(ByVal emp_code As Integer) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_getEmployeeMedicalPlan", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@emp_code", emp_code)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try


    End Function

    Public Shared Function getContractEmployeeByCodeWithDesc(ByVal emp_code As Integer, ByVal payrollMonth As Integer, ByVal payrollYear As Integer) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_getContractEmployeeByCode", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@emp_code", emp_code)
        cmd.Parameters.AddWithValue("@payrollmonth", payrollMonth)
        cmd.Parameters.AddWithValue("@payrollyear", payrollYear)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try


    End Function

    Public Shared Function getPayrollCurrentMonthAndYear() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_getPayrollCurrentMonthAndYear", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try


    End Function

    Public Shared Function SaveEmployeeLeavePlan(ByVal emp_code As Integer, ByVal start_date As Date, ByVal end_date As Date) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_SaveEmployeeLeavePlan", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@emp_code", emp_code)
        cmd.Parameters.AddWithValue("@start_date", start_date)
        cmd.Parameters.AddWithValue("@end_date", end_date)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function

    Public Shared Function SaveEmployeeMedicalPlan(ByVal emp_code As Integer, ByVal hospital_code As Integer, ByVal c_no As String, ByVal date_of_exam As Date, ByVal amount As Integer) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_SaveEmployeeMedicalPlan", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@emp_code", emp_code)
        cmd.Parameters.AddWithValue("@hospital_code", hospital_code)
        cmd.Parameters.AddWithValue("@c_no", c_no)
        cmd.Parameters.AddWithValue("@date_of_exam", date_of_exam)
        cmd.Parameters.AddWithValue("@amount", amount)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function
    Public Shared Function getMasterEmployee_ContractList_Search(ByVal value As String, ByVal User_Code As Integer) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_ContractList_Search", cn)
        cmd.Parameters.AddWithValue("@SearchType", "N")
        cmd.Parameters.AddWithValue("@Value", value)
        cmd.Parameters.AddWithValue("@User_Code", User_Code)
        cmd.CommandType = CommandType.StoredProcedure



        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function
    Public Shared Function getMasterEmployee_ContractList() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_ContractList", cn)
        cmd.CommandType = CommandType.StoredProcedure



        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function

    Public Shared Function getContractEmployee_Renewal_History(ByVal emp_Code As Integer) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_getContractEmployeeRenewelHistory", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@emp_code", emp_Code)

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function
    Public Shared Function get_JobDEscription(ByVal Emp_Code As Integer) As Integer
        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("JobDescription", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Emp_code", Emp_Code)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet



        Try
            da.Fill(ds)
            Return ds.Tables(0).Rows(0)(0)
        Catch ex As Exception
            Throw ex
        Finally

        End Try
    End Function
    Public Shared Function Add_JobDEscription(ByVal Emp_Code As Integer, ByVal Grade_Code As Integer) As DataSet
        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("Sp_JobDescription_Add", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Emp_code", Emp_Code)
        cmd.Parameters.AddWithValue("@Grade_Code", Grade_Code)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet



        Try
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function

    Public Shared Function getMasterEmployee_ContractList_ForAppraisal() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_ContractList_ForAppraisal", cn)
        cmd.CommandType = CommandType.StoredProcedure



        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function
    Public Shared Function getMasterEmployee_Search_HistoryAppointments(ByVal SType As Char, ByVal Val As String) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_HistoryAppointments_MasterEmployees_Search", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim SearchType As New SqlParameter("@SearchType", SqlDbType.Char, 1, ParameterDirection.Input)
        SearchType.Value = SType
        cmd.Parameters.Add(SearchType)

        Dim Value As New SqlParameter("@Value", SqlDbType.VarChar, 100, ParameterDirection.Input)
        Value.Value = Val
        cmd.Parameters.Add(Value)

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet


        da.Fill(ds, "Master_Employees")
        Return ds
        cn = Nothing
        da = Nothing
        ds = Nothing

    End Function
    Public Shared Function getMasterEmployee_List_HistoryAppointments() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_History_MasterEmployees_List_History_Appointments", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 0
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function

    Public Shared Function getMasterEmployee_List_User(ByVal emp_code1 As Integer) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_List_User", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim Emp_Code As New SqlParameter("@emp_code", SqlDbType.Int, ParameterDirection.Input)
        Emp_Code.Value = emp_code1
        cmd.Parameters.Add(Emp_Code)


        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            'ds = Nothing
        End Try
    End Function

    Public Shared Function getMasterEmployee_List_User_only(ByVal emp_code1 As Integer) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_List_User_only", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim Emp_Code As New SqlParameter("@emp_code", SqlDbType.Int, ParameterDirection.Input)
        Emp_Code.Value = emp_code1
        cmd.Parameters.Add(Emp_Code)


        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            'ds = Nothing
        End Try
    End Function

    Public Shared Function getMasterEmployees_MasterDataWithSalary() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("master_employees_detail_data_salary", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet

            da.Fill(ds)
            Return ds

        Catch ex As Exception
            Throw ex
        Finally
            cn.Close()
            cn = Nothing
        End Try

    End Function
    Public Shared Function getMasterEmployees_MasterDataWithDetails() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("master_employees_detail_data", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet

            da.Fill(ds)
            Return ds

        Catch ex As Exception
            Throw ex
        Finally
            cn.Close()
            cn = Nothing
        End Try

    End Function
    Public Shared Function getMasterEmployees_MasterDataWithResignDetails() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("resigned_employees_detail_data", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet

            da.Fill(ds)
            Return ds

        Catch ex As Exception
            Throw ex
        Finally
            cn.Close()
            cn = Nothing
        End Try

    End Function
    Public Shared Function getMasterEmployees_MasterDataWithColumns() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("master_employees_detail_data_columnWise", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet

            da.Fill(ds)
            Return ds

        Catch ex As Exception
            Throw ex
        Finally
            cn.Close()
            cn = Nothing
        End Try

    End Function
    Public Shared Function getMasterAllEmployees_MasterDataWithColumns() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("master_all_employees_detail_data_columnWise", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet

            da.Fill(ds)
            Return ds

        Catch ex As Exception
            Throw ex
        Finally
            cn.Close()
            cn = Nothing
        End Try

    End Function
    Public Shared Function getMasterEmployees_MasterDataPaysheet(ByVal Year) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("master_employees_data_paysheet", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Try
            cn.Open()
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet

            da.Fill(ds)
            Return ds

        Catch ex As Exception
            Throw ex
        Finally
            cn.Close()
            cn = Nothing
        End Try

    End Function
    Public Shared Function getMasterEmployees_MasterDataAdvanceSalary(ByVal mDateFrom As Date, ByVal mDateTo As Date) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("master_employees_data_advanceSalary", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim DateFrom As New SqlParameter("@DateFrom", SqlDbType.Date, ParameterDirection.Input)
        DateFrom.Value = mDateFrom
        cmd.Parameters.Add(DateFrom)

        Dim DateTo As New SqlParameter("@DateTo", SqlDbType.Date, ParameterDirection.Input)
        DateTo.Value = mDateTo
        cmd.Parameters.Add(DateTo)

        Try
            cn.Open()
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds

        Catch ex As Exception
            Throw ex
        Finally
            cn.Close()
            cn = Nothing
        End Try

    End Function

    Public Shared Function JVGenerationExcelData(ByVal Year As Integer, ByVal month As Integer) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("Proc_Jv_Generation", cn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@payslip_year", Year)
        cmd.Parameters.AddWithValue("@payslip_month", month)


        Try
            cn.Open()
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet

            da.Fill(ds)
            Return ds

        Catch ex As Exception
            Throw ex
        Finally
            cn.Close()
            cn = Nothing
        End Try

    End Function

    Public Shared Function UpdateContractEmployeeRenewelPlan(ByVal emp_code As Integer, ByVal Start_Date As Date, ByVal end_date As Date, ByVal NoOfMonths As Integer, ByVal Start_Date1 As Date, ByVal end_date1 As Date, ByVal NoOfMonths1 As Integer, ByVal payslip_month As Integer, ByVal payslip_year As Integer)


        Dim EndDate As New Date
        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_UpdateContractEmployeeRenewelPlan", cn)
        cmd.CommandType = CommandType.StoredProcedure

        'EndDate = Start_Date.AddMonths(NoOfMonths)

        cmd.Parameters.AddWithValue("@emp_code", emp_code)
        cmd.Parameters.AddWithValue("@start_date", Start_Date)
        cmd.Parameters.AddWithValue("@end_date", end_date)
        cmd.Parameters.AddWithValue("@no_of_month", NoOfMonths)
        cmd.Parameters.AddWithValue("@start_date1", Start_Date1)
        cmd.Parameters.AddWithValue("@end_date1", end_date1)
        cmd.Parameters.AddWithValue("@no_of_month1", NoOfMonths1)
        cmd.Parameters.AddWithValue("@payslip_month", payslip_month)
        cmd.Parameters.AddWithValue("@payslip_year", payslip_year)

        cmd.Parameters.AddWithValue("@Posted_by", System.Web.HttpContext.Current.Session("Emp_code"))

        'Dim da As New SqlDataAdapter(cmd)
        'Dim ds As New DataSet

        Try
            'da.Fill(ds, "Master_Employees")
            'Return ds
            cn.Open()
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            'da = Nothing
            'ds = Nothing
        End Try


    End Function
    Public Shared Function DeleteContractEmployeeRenewelPlan1(ByVal emp_code As Integer, ByVal Start_Date As Date, ByVal end_date As Date, ByVal NoOfMonths As Integer, ByVal payslip_month As Integer, ByVal payslip_year As Integer)

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_DeleteContractEmployeeRenewelPlan1", cn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@emp_code", emp_code)
        cmd.Parameters.AddWithValue("@start_date", Start_Date)
        cmd.Parameters.AddWithValue("@end_date", end_date)
        cmd.Parameters.AddWithValue("@no_of_month", NoOfMonths)
        cmd.Parameters.AddWithValue("@payslip_month", payslip_month)
        cmd.Parameters.AddWithValue("@payslip_year", payslip_year)

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            cn.Close()
            cn = Nothing
        End Try

    End Function

    Public Shared Function getBranchManagers_List() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_BranchManager_List", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
        End Try

    End Function

    Public Shared Function getOperationManagers_List() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_OperationManager_List", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@User_Code", System.Web.HttpContext.Current.Session("Emp_Code"))
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
        End Try

    End Function

    Public Shared Function getMasterEmployee_Search_TranLeaves(ByVal mEmpCode As Integer, ByVal mCodeID As Integer) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_Search_TranLeaves", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim EmpCode As New SqlParameter("@Emp_Code", SqlDbType.Int, ParameterDirection.Input)
        EmpCode.Value = mEmpCode
        cmd.Parameters.Add(EmpCode)

        Dim CodeID As New SqlParameter("@CodeID", SqlDbType.Int, ParameterDirection.Input)
        CodeID.Value = mCodeID
        cmd.Parameters.Add(CodeID)



        'Dim SearchType As New SqlParameter("@SearchType", SqlDbType.Char, 1, ParameterDirection.Input)
        'SearchType.Value = SType
        'cmd.Parameters.Add(SearchType)

        'Dim Value As New SqlParameter("@Value", SqlDbType.VarChar, 100, ParameterDirection.Input)
        'Value.Value = Val()
        'cmd.Parameters.Add(Value)





        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
        End Try

    End Function

    Public Shared Function getMasterEmployeeInfo_ByCode(ByVal emp_code1 As Integer) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("sp_MasterEmployeesInfo_ByCode", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim Emp_Code As New SqlParameter("@emp_code", SqlDbType.Int, ParameterDirection.Input)
        Emp_Code.Value = emp_code1
        cmd.Parameters.Add(Emp_Code)

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
        End Try

    End Function

    Public Shared Function getMasterEmployees_MasterDataColumnwise(ByVal RegCode As Integer, ByVal ArCode As Integer, ByVal CtyCode As Integer, ByVal LocCode As Integer, ByVal GrdCode As Integer, ByVal SecCode As Integer, ByVal DesigCode As Integer, ByVal ActFlag As String, ByVal TDate As Date) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("ExcelDownload_Proc_Master_All_Employees_detail_data_columnwise", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim RegionCode As New SqlParameter("@region_code", SqlDbType.Int, ParameterDirection.Input)
        RegionCode.Value = RegCode
        cmd.Parameters.Add(RegionCode)


        Dim AreaCode As New SqlParameter("@Area_code", SqlDbType.Int, ParameterDirection.Input)
        AreaCode.Value = ArCode
        cmd.Parameters.Add(AreaCode)

        Dim CityCode As New SqlParameter("@City_Code", SqlDbType.Int, ParameterDirection.Input)
        CityCode.Value = CtyCode
        cmd.Parameters.Add(CityCode)

        Dim LocationCode As New SqlParameter("@Loc_Code", SqlDbType.Int, ParameterDirection.Input)
        LocationCode.Value = LocCode
        cmd.Parameters.Add(LocationCode)

        Dim GradeCode As New SqlParameter("@Grade_COde", SqlDbType.Int, ParameterDirection.Input)
        GradeCode.Value = GrdCode
        cmd.Parameters.Add(GradeCode)

        Dim DesignationCode As New SqlParameter("@Desig_code", SqlDbType.Int, ParameterDirection.Input)
        DesignationCode.Value = DesigCode
        cmd.Parameters.Add(DesignationCode)

        Dim SectionCode As New SqlParameter("@section_code", SqlDbType.Int, ParameterDirection.Input)
        SectionCode.Value = SecCode
        cmd.Parameters.Add(SectionCode)

        Dim ActiveFLag As New SqlParameter("@Active_FLag", SqlDbType.VarChar, 1, ParameterDirection.Input)
        ActiveFLag.Value = ActFlag
        cmd.Parameters.Add(ActiveFLag)

        Dim TillDate As New SqlParameter("@Tilldate", SqlDbType.DateTime, ParameterDirection.Input)
        TillDate.Value = TDate
        cmd.Parameters.Add(TillDate)


        Try
            cn.Open()
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet

            da.Fill(ds)
            Return ds

        Catch ex As Exception
            Throw ex
        Finally

            cn.Close()
            cn = Nothing
        End Try

    End Function

    Public Shared Function getMasterEmployees_MasterDataColumnwise_training(ByVal RegCode As Integer, ByVal LocCode As Integer, ByVal GrdCode As Integer, ByVal SecCode As Integer, ByVal DesigCode As Integer, ByVal ActFlag As String, ByVal TDate As Date, ByVal TDate1 As Date) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("ExcelDownload_Proc_Master_All_Employees_detail_data_columnwise_training", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim RegionCode As New SqlParameter("@emp_code", SqlDbType.Int, ParameterDirection.Input)
        RegionCode.Value = RegCode
        cmd.Parameters.Add(RegionCode)

        Dim LocationCode As New SqlParameter("@Loc_Code", SqlDbType.Int, ParameterDirection.Input)
        LocationCode.Value = LocCode
        cmd.Parameters.Add(LocationCode)

        Dim GradeCode As New SqlParameter("@Grade_COde", SqlDbType.Int, ParameterDirection.Input)
        GradeCode.Value = GrdCode
        cmd.Parameters.Add(GradeCode)

        Dim DesignationCode As New SqlParameter("@Desig_code", SqlDbType.Int, ParameterDirection.Input)
        DesignationCode.Value = DesigCode
        cmd.Parameters.Add(DesignationCode)

        Dim SectionCode As New SqlParameter("@section_code", SqlDbType.Int, ParameterDirection.Input)
        SectionCode.Value = SecCode
        cmd.Parameters.Add(SectionCode)

        Dim ActiveFLag As New SqlParameter("@Active_FLag", SqlDbType.VarChar, 1, ParameterDirection.Input)
        ActiveFLag.Value = ActFlag
        cmd.Parameters.Add(ActiveFLag)

        Dim TillDate As New SqlParameter("@fromdate", SqlDbType.DateTime, ParameterDirection.Input)
        TillDate.Value = TDate
        cmd.Parameters.Add(TillDate)

        Dim ToDate As New SqlParameter("@Todate", SqlDbType.DateTime, ParameterDirection.Input)
        ToDate.Value = TDate1
        cmd.Parameters.Add(ToDate)


        Try
            cn.Open()
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet

            da.Fill(ds)
            Return ds

        Catch ex As Exception
            Throw ex
        Finally
            cn.Close()
            cn = Nothing
        End Try

    End Function




    Public Shared Function getMasterEmployee_List_PayrollCategoryWise(ByVal emp_payroll_Category As Integer) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_List_PayrollCategoryWise_new", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@emp_payroll_Category", emp_payroll_Category)

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet




        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function




    Public Shared Function getMasterAllEmployee_List_with_code_zero_employee() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterAllEmployees_List_code_withzero_employee", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function



    Public Shared Function getMasterEmployee_Search(ByVal ActFlag As String) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("admin_get_all_users", cn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Dim search As New SqlParameter("@search", SqlDbType.VarChar, 20, ParameterDirection.Input)
        search.Value = ActFlag
        cmd.Parameters.Add(ActFlag)

        Try
            da.Fill(ds, "MasterEmployees_Search")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function


    Public Shared Function getMasterEmployee_List_Leave(ByVal codeID As Integer) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_List_Leave", cn)
        cmd.Parameters.AddWithValue("@codeID", codeID)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function

    Public Shared Function getMasterEmployee_Search_Leave(ByVal SType As Char, ByVal Val As String, ByVal codeID As Integer) As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_Search_Leave", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim SearchType As New SqlParameter("@SearchType", SqlDbType.Char, 1, ParameterDirection.Input)
        SearchType.Value = SType
        cmd.Parameters.Add(SearchType)

        Dim Value As New SqlParameter("@Value", SqlDbType.VarChar, 100, ParameterDirection.Input)
        Value.Value = Val
        cmd.Parameters.Add(Value)

        cmd.Parameters.AddWithValue("@codeID", codeID)

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function

    Public Shared Function UndoMasterEmployees(ByVal MEmp As MasterEmployeesInfo) As Boolean


        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_Appointments_Undo", cn)
        cmd.CommandType = CommandType.StoredProcedure

        ' creating parameters
        Dim Empcode As New SqlParameter("@Emp_code", SqlDbType.Int, ParameterDirection.Input)
        Empcode.Value = MEmp.Emp_code
        cmd.Parameters.Add(Empcode)
        cmd.Parameters.AddWithValue("@UserCode", System.Web.HttpContext.Current.Session("Emp_code"))


        Try
            cn.Open()
            Dim result As Integer
            result = cmd.ExecuteNonQuery()
            If result > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        Finally
            cn.Close()
            cn = Nothing

        End Try

    End Function

    Public Shared Function getMasterEmployee_All_List() As DataSet

        Dim cn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("HRDBConnectionString").ToString)
        Dim cmd As New SqlCommand("SP_PER_MasterEmployees_All_List", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@User_Code", System.Web.HttpContext.Current.Session("Emp_code"))
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "Master_Employees")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cn = Nothing
            da = Nothing
            ds = Nothing
        End Try
    End Function

End Class