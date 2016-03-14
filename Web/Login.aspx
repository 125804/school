
<%@ Page Title="登录" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web.Login" Async="true" %>



<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>

    <div class="row">
        <div class="col-md-8">
            <section id="loginForm">
                <div class="form-horizontal">
                    <h4>使用本地帐户登录。</h4>
                    <hr />
                      <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="UserName" CssClass="col-md-2 control-label">用户名</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="UserName" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName"
                                CssClass="text-danger" ErrorMessage="“用户名”字段是必填字段。" />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-2 control-label">密码</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="text-danger" ErrorMessage="“密码”字段是必填字段。" />
                        </div>
                    </div>
                    <div class="form-group">
                         <asp:Label runat="server" AssociatedControlID="DropDownList1" CssClass="col-md-2 control-label">类型</asp:Label>
                        <div class=" col-md-10">

                            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" >
                                <asp:ListItem Value="1">管理员</asp:ListItem>
                                <asp:ListItem Value="2">学生</asp:ListItem>
                            </asp:DropDownList>
                       
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server" id="submit" Text="登录" CssClass="btn btn-default" OnClick="submit_Click" />
                            
                        </div>
                    </div>
                </div>
                <p>
                   
                </p>
            </section>
        </div>

        <div class="col-md-4">
          
        </div>
    </div>
</asp:Content>

