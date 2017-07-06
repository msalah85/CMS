<%@ Page Title="News" Language="C#" MasterPageFile="master.master" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="Share.CMS.Web.sys.News" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="//cdn.ckeditor.com/4.7.1/standard/ckeditor.js"></script>
    <script src="/Scripts/sys/Common.js?v=1.3"></script>
    <script src="/Scripts/sys/DataService.min.js"></script>
    <script src="/Scripts/sys/DefaultGridVariables.js"></script>
    <script src="/content/sys/assets/js/jquery.validate.min.js"></script>
    <script src="/content/sys/assets/js/additional-methods.min.js"></script>
    <script src="/Scripts/sys/DefaultGridManager.min.js"></script>
    <script src="/Scripts/jquery.friendurl/jquery.friendurl.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="breadcrumbs" id="breadcrumbs">
        <ul class="breadcrumb">
            <li>
                <i class="icon-home home-icon"></i>
                <a href="#">Home</a>
                <span class="divider">
                    <i class="icon-angle-right arrow-icon"></i>
                </span>
            </li>
            <li class="active">News</li>
        </ul>
    </div>
    <div class="page-content">
        <div class="page-header position-relative">
            <h1>News Management</h1>
        </div>
        <div class="row">
            <div class="col-xs-12 widget-container-col">
                <div class="clearfix">
                    <a role="button" href="#addModal" data-toggle="modal" class="btn btn-white btn-warning btn-bold"
                        tabindex="0" title="Add new"><i class="fa fa-plus bigger-110"></i>Add new</a>
                    <div class="pull-right tableTools-container"></div>

                    
    <textarea id="Details2"></textarea>
                </div>
                <div class="widget-box widget-color-blue" id="widget-box-2">
                    <div class="widget-header">
                        <h5 class="widget-title bigger lighter">
                            <i class="ace-icon fa fa-table"></i>
                            Features List
                        </h5>

                        <div class="widget-toolbar">
                            <a href="#" data-action="fullscreen" class="white">
                                <i class="1 ace-icon fa fa-expand bigger-125"></i>
                            </a>
                        </div>
                    </div>
                    <div class="widget-body">
                        <div class="widget-main no-padding">
                            <table id="itemsDataTable" class="table table-striped table-bordered table-hover">
                                <thead>
                                    <tr>
                                        <th>Title</th>
                                        <th>Article URL</th>
                                        <th>Brief Desc</th>
                                        <th>ID</th>
                                        <th>Parent Article</th>
                                        <th>Translate Article</th>
                                        <th>Language</th>
                                        <th>Options</th>
                                        <th></th>
                                    </tr>
                                </thead>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div id="addModal" class="modal fade" tabindex="-1">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header no-padding">
                            <div class="table-header">
                                <button type="button" class="close" data-dismiss="modal" aria-hidden="true">
                                    <span class="white">&times;</span>
                                </button>
                                Add/Edit Feature
                            </div>
                        </div>
                        <div class="modal-body">
                            <div class="row">
                                <div class="col-xs-12 col-sm-12">
                                    <form class="form-horizontal" role="form" id="aspnetForm">
                                        <input type="hidden" id="FeatureID" value="0" />
                                        <div class="form-group">
                                            <label class="col-sm-3 control-label no-padding-right">Master Feature (optional)</label>
                                            <div class="col-sm-9">
                                                <select class="col-sm-10 select2" id="FeatureParentID" name="FeatureParentID" data-fn-name="Features_Names" data-placeholder="Parent Feature" data-allow-clear="true">
                                                    <option value=""></option>
                                                </select>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <label for="FeatureName" class="col-sm-3 control-label no-padding-right">Feature name <span class="text-danger">*</span></label>
                                            <div class="col-sm-9">
                                                <input type="text" class="col-sm-10 required" required id="FeatureName" name="FeatureName" placeholder="Feature name" />
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <label for="FeatureNameAr" class="col-sm-3 control-label no-padding-right">Feature (Arabic) <span class="text-danger">*</span></label>
                                            <div class="col-sm-9">
                                                <input type="text" class="col-sm-10 required" required id="FeatureNameAr" name="FeatureNameAr" placeholder="Arabic name" />
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <label for="Icon" class="col-sm-3 control-label no-padding-right">Icon</label>
                                            <div class="col-sm-9">
                                                <input type="text" class="col-sm-10 required" id="Icon" name="Icon" placeholder="Icon tag" />
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <label for="Details" class="control-label no-padding-right">Details</label>
                                            <div class="col-sm-12">
                                                <textarea class="col-sm-10 required" id="Details" name="Details"></textarea>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <label for="Active" class="col-sm-3 control-label no-padding-right">Active</label>
                                            <div class="col-sm-9">
                                                <div class="checkbox">
                                                    <label>
                                                        <input id="Active" type="checkbox" class="ace" />
                                                        <span class="lbl">Yes (Active).</span>
                                                    </label>
                                                </div>
                                            </div>
                                        </div>
                                    </form>
                                </div>
                            </div>
                        </div>
                        <div class="modal-footer no-margin-top">
                            <button class="btn btn-sm btn-primary" id="btnSave">
                                <i class="ace-icon fa fa-check"></i>
                                Save
                            </button>
                            <button class="btn btn-sm btn-danger" data-dismiss="modal">
                                <i class="ace-icon fa fa-times"></i>
                                Close
                            </button>
                        </div>
                    </div>
                </div>
            </div>
            <div id="deleteModal" class="modal hide fade" tabindex="-1">
                <div class="modal-header no-padding">
                    <div class="table-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        Delete Article
                    </div>
                </div>
                <div class="modal-body">
                    <form class="form-horizontal" id="removeForm">
                        <div class="alert alert-warning">
                            <label>Are you sure to delete this item  (  #<strong class="removeField"></strong>  )?</label>
                        </div>
                    </form>
                </div>
                <div class="modal-footer">
                    <button class="btn btn-small btn-danger pull-right btn-delete">
                        <i class="icon-trash"></i>
                        Delete
                    </button>
                </div>
            </div>
        </div>
    </div>

    <script>
        var targetdata;
        tableName = "Articles";
        pKey = "ArticleID";
        gridId = "itemsDataTable";
        gridColumns = [
            {
                "mDataProp": "ArticleTitle",
                "bSearchable": true,
                "bSortable": true
            },
            {
                "mDataProp": "RouteURL",
                "bSearchable": true,
                "bSortable": true
            },
            {
                "mDataProp": "BriefDesc",
                "bSearchable": true,
                "bSortable": true
            }, {
                "mDataProp": "ArticleID",
                "bSearchable": false,
                "bSortable": true
            }
            , {
                "mDataProp": "ParentArticleID",
                "bSearchable": false,
                "bSortable": true
            }
            , {
                "mDataProp": "TranslateArticleID",
                "bSearchable": true,
                "bSortable": true
            },
            {
                "mDataProp": "LanguageID",
                "bSearchable": true,
                "bSortable": true
            }, {
                "bSortable": false,
                "mData": function () {
                    return '<button class="btn btn-primary btn-small edit" title="تعديل"><i class="icon-pencil"></i></button>' +
                        '<button class="btn btn-danger btn-small remove" title="حذف"><i class="icon-trash"></i></button>'
                }
            },
            {
                "mDataProp": "TransArticleID",
                "bSearchable": false,
                "bSortable": false,
                "bVisible": false
            }, {
                "mDataProp": "ParArticleID",
                "bSearchable": false,
                "bSortable": false,
                "bVisible": false
            }];

        DefaultGridManager.Init();

        $.fn.afterSave = function (modalDialog, form, success, error) {
            $("#ParentArticleID").html('');
            $("#ParentArticleID").html('<option value="" />');
            $("#TranslateArticleID").html('');
            $("#TranslateArticleID").html('<option value="" />');
            $("#LanguageID").html('');
            $("#LanguageID").html('<option value="" />');
            commonManger.fillLists();
        }

        $.fn.beforeSave = function () {
            if ($("#ParentArticleID").find('option:selected').text() == $("#ArticleTitle").val()) {
                commonManger.showMessage('danger', "Please Choose another Parent Categor", "Please Choose another Parent Article");
                return false;
            }

            if ($("#TranslateArticleID").find('option:selected').text() == $("#ArticleTitle").val()) {
                commonManger.showMessage('danger', "Please Choose another Parent Categor", "Please Choose another Translate Article");
                return false;
            }

            if ($('#RouteURL').val().trim() == "") {
                var ArticleTitle = $('#ArticleTitle').val();
                ArticleTitle = ArticleTitle.replace(/\s+/g, '-').toLowerCase();
                $('#RouteURL').val(ArticleTitle);
                return true;
            }
            else { return true }
        }

        $.fn.afterLoadData = function (ArrayData) {
            $('#LanguageID').trigger('change');
            targetdata = ArrayData;
        }

        
        CKEDITOR.replace('Details');
    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <style>
        #cke_32,
        .cke_button__about{display:none!important}
    </style>
</asp:Content>
