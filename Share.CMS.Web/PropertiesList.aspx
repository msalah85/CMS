<%@ Page Title="نتيجة البحث" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PropertiesList.aspx.cs" Inherits="Share.CMS.Web.WebForm2" %>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <script src="/Scripts/app/services/DataService.min.js"></script>
    <script src="/Scripts/app/services/Common.min.js"></script>
    <script src="/Scripts/app/utiltities/jquery.xml2json.min.js"></script>


</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="buildings text-center">
        <div class="slider">
            <div class="container">
                <img src="/content/MasknVr1/img/deals.png" class="img-responsive" />
                <h5>مباتي غسان</h5>
                <p>
                    هذا نص تجريبي يمكن أن يستبدل في مكانه
                </p>
                <i class="material-icons btn-floating waves-effect waves-light orange pull-left">room</i>
            </div>
        </div>
        <div class="buildingsDetails">
            <div class="container">
                <div class="filter">
                    <div class="row">
                        <div class="col-md-2">
                            <div class="input-group adv-search">
                                <div class="input-group-btn">
                                    <div class="btn-group" role="group">
                                        <div class="dropdown dropdown-lg">
                                            <button type="button" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-expanded="false">الميزانية  <span class="caret"></span></button>
                                            <div class="dropdown-menu dropdown-menu-right" role="menu">
                                                <form class="form-horizontal" role="form">
                                                    <div class="row">
                                                        <div class="col m6 l6">
                                                            <div class="form-group">
                                                                <label>$ </label>
                                                                <input class="form-control" type="text" id="contain" />
                                                            </div>
                                                        </div>
                                                        <div class="col m6 l6">
                                                            <div class="form-group">
                                                                <label>$ </label>
                                                                <input class="form-control" type="text" id="contain2" />
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="collection">
                                                        <a href="#" class="collection-item">100</a>
                                                        <a href="#" class="collection-item ">200</a>
                                                        <a href="#" class="collection-item">300</a>
                                                        <a href="#" class="collection-item">400</a>
                                                    </div>
                                                </form>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-2">
                            <div class="input-group adv-search bedroom">
                                <div class="input-group-btn">
                                    <div class="btn-group" role="group">
                                        <div class="dropdown dropdown-lg">
                                            <button type="button" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-expanded="false">غرف النوم  <span class="caret"></span></button>
                                            <div class="dropdown-menu dropdown-menu-right" role="menu">
                                                <form class="form-horizontal" role="form">
                                                    <div class="row">
                                                        <div class="col m3">
                                                            <label>
                                                                <input type="checkbox" />
                                                                1 BHK
                                                            </label>
                                                        </div>
                                                        <div class="col m3">
                                                            <label>
                                                                <input type="checkbox" />
                                                                2 BHK
                                                            </label>
                                                        </div>
                                                        <div class="col m3">
                                                            <label>
                                                                <input type="checkbox" />
                                                                3 BHK
                                                            </label>
                                                        </div>
                                                        <div class="col m3">
                                                            <label>
                                                                <input type="checkbox" />
                                                                4 BHK
                                                            </label>
                                                        </div>
                                                    </div>
                                                </form>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-2">
                            <div class="input-group adv-search more">
                                <div class="input-group-btn">
                                    <div class="btn-group" role="group">
                                        <div class="dropdown dropdown-lg">
                                            <button type="button" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-expanded="false">المزيد  <span class="caret"></span></button>
                                            <div class="dropdown-menu dropdown-menu-right" role="menu" style="min-width: 750px">
                                                <form class="form-horizontal" role="form">
                                                    <div class="formLeft" style="width: 70%; float: right">
                                                        <div class="row">
                                                            <div class="col m12 12">
                                                                <h6>دورات المياه </h6>
                                                                <div class="row">
                                                                    <div class="col m2">
                                                                        <label class="bathroom">
                                                                            <input type="checkbox" />
                                                                            1 +
                                                                        </label>
                                                                    </div>
                                                                    <div class="col m2">
                                                                        <label class="bathroom">
                                                                            <input type="checkbox" />
                                                                            2 +
                                                                        </label>
                                                                    </div>
                                                                    <div class="col m2">
                                                                        <label class="bathroom">
                                                                            <input type="checkbox" />
                                                                            3 +
                                                                        </label>
                                                                    </div>
                                                                    <div class="col m2">
                                                                        <label class="bathroom">
                                                                            <input type="checkbox" />
                                                                            4 +
                                                                        </label>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="col l12 m12">
                                                                <div class="row">
                                                                    <div class="col m6 l6">
                                                                        <h6>مساحة العقار </h6>
                                                                        <select class="browser-default">
                                                                            <option value="" disabled selected>اختر </option>
                                                                            <option value="1">Option 1</option>
                                                                            <option value="2">Option 2</option>
                                                                            <option value="3">Option 3</option>
                                                                        </select>
                                                                    </div>
                                                                    <div class="col m6 l6">
                                                                        <h6>جديد / معاد بيعه </h6>
                                                                        <select class="browser-default">
                                                                            <option value="" disabled selected>اختر </option>
                                                                            <option value="1">الكل </option>
                                                                            <option value="2">جديد </option>
                                                                            <option value="3">معاد بيعه </option>
                                                                        </select>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="col m12 l12">
                                                                <h6>Under Construction (Possession In)</h6>
                                                                <div class="row">
                                                                    <div class="col m3">
                                                                        <label class="bathroom">
                                                                            <input type="checkbox" />
                                                                            1 Year
                                                                        </label>
                                                                    </div>
                                                                    <div class="col m3">
                                                                        <label class="bathroom">
                                                                            <input type="checkbox" />
                                                                            2 Years
                                                                        </label>
                                                                    </div>
                                                                    <div class="col m3">
                                                                        <label class="bathroom">
                                                                            <input type="checkbox" />
                                                                            3 Years
                                                                        </label>
                                                                    </div>
                                                                    <div class="col m3">
                                                                        <label class="bathroom">
                                                                            <input type="checkbox" />
                                                                            4 Years
                                                                        </label>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="col m12 l12">
                                                                <h6>Under Construction (Possession In)</h6>
                                                                <div class="row">
                                                                    <div class="col m3">
                                                                        <label class="bathroom">
                                                                            <input type="checkbox" />
                                                                            1 Year
                                                                        </label>
                                                                    </div>
                                                                    <div class="col m3">
                                                                        <label class="bathroom">
                                                                            <input type="checkbox" />
                                                                            2 Years
                                                                        </label>
                                                                    </div>
                                                                    <div class="col m3">
                                                                        <label class="bathroom">
                                                                            <input type="checkbox" />
                                                                            3 Years
                                                                        </label>
                                                                    </div>
                                                                    <div class="col m3">
                                                                        <label class="bathroom">
                                                                            <input type="checkbox" />
                                                                            4 Years
                                                                        </label>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="formRight" style="width: 30%; float: left">
                                                        <div class="row">
                                                            <div class="col m12 l12">
                                                                <div class="checkBoxProperty" style="float: right">
                                                                    <h6>property type </h6>
                                                                    <p style="margin-top: 20px;">
                                                                        <input type="checkbox" class="filled-in" id="choice1" />
                                                                        <label for="choice1">تجريبي </label>
                                                                    </p>
                                                                    <p style="margin-top: 5px;">
                                                                        <input type="checkbox" class="filled-in" id="choice2" />
                                                                        <label for="choice2">تجريبي </label>
                                                                    </p>
                                                                    <p style="margin-top: 5px;">
                                                                        <input type="checkbox" class="filled-in" id="choice3" />
                                                                        <label for="choice3">تجريبي </label>
                                                                    </p>
                                                                    <p style="margin-top: 5px;">
                                                                        <input type="checkbox" class="filled-in" id="choice4" />
                                                                        <label for="choice4">تجريبي </label>
                                                                    </p>
                                                                </div>
                                                            </div>
                                                            <div class="col m12 l12">
                                                                <div class="checkBoxProperty" style="float: right">
                                                                    <h6>property type </h6>
                                                                    <p style="margin-top: 20px;">
                                                                        <input type="checkbox" class="filled-in" id="choice5" />
                                                                        <label for="choice5">تجريبي </label>
                                                                    </p>
                                                                    <p style="margin-top: 5px;">
                                                                        <input type="checkbox" class="filled-in" id="choice6" />
                                                                        <label for="choice6">تجريبي </label>
                                                                    </p>
                                                                    <p style="margin-top: 5px;">
                                                                        <input type="checkbox" class="filled-in" id="choice7" />
                                                                        <label for="choice7">تجريبي </label>
                                                                    </p>
                                                                    <p style="margin-top: 5px;">
                                                                        <input type="checkbox" class="filled-in" id="choice8" />
                                                                        <label for="choice8">تجريبي </label>
                                                                    </p>
                                                                </div>
                                                            </div>
                                                            <div class="col m12 l12">
                                                                <div class="checkBoxProperty" style="float: right">
                                                                    <h6>property type </h6>
                                                                    <p style="margin-top: 20px;">
                                                                        <input type="checkbox" class="filled-in" id="choice9" />
                                                                        <label for="choice9"></label>
                                                                    </p>
                                                                    <p style="margin-top: 5px;">
                                                                        <input type="checkbox" class="filled-in" id="choice10" />
                                                                        <label for="choice10">تجريبي </label>
                                                                    </p>
                                                                    <p style="margin-top: 5px;">
                                                                        <input type="checkbox" class="filled-in" id="choice11" />
                                                                        <label for="choice11">تجريبي </label>
                                                                    </p>
                                                                    <p style="margin-top: 5px;">
                                                                        <input type="checkbox" class="filled-in" id="choice12" />
                                                                        <label for="choice12">تجريبي </label>
                                                                    </p>
                                                                </div>
                                                            </div>

                                                        </div>
                                                    </div>
                                                </form>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col s12 m8 l8">
                        <div class="buildingLeftPart">
                            <div class="buildingCard">
                                <div class="row">
                                    <div class="col m4 l4">
                                        <div class='buldImg'>
                                            <!-- image -->
                                            <img src='/content/MasknVr1/img/building.png' class="img-responsive" alt="" title="build" />
                                            <!-- description div -->
                                            <div class='description'>
                                                <!-- description content -->
                                                <h6 class='description_content'>نص تجريبي </h6>
                                                <fieldset class="rating">
                                                    <input type="radio" id="star25" name="rating" value="5" />
                                                    <label class="full" for="star25" title="5 start"></label>

                                                    <input type="radio" id="star24" name="rating" value="4" />
                                                    <label class="full" for="star24" title="4 stars "></label>
                                                    <input type="radio" id="star23" name="rating" value="3" />
                                                    <label class="full" for="star23" title="3 stars"></label>

                                                    <input type="radio" id="star22" name="rating" value="2" />
                                                    <label class="full" for="star22" title="2 stars"></label>

                                                    <input type="radio" id="star21" name="rating" value="1" />
                                                    <label class="full" for="star21" title="bad  1 star"></label>

                                                </fieldset>
                                                <a href="#" class="fav active"><i class="material-icons ">favorite_border</i> </a>
                                                <!-- end description content -->
                                            </div>
                                            <!-- end description div -->
                                        </div>
                                    </div>
                                    <div class="col m8 l8">
                                        <div class="BuildRight">
                                            <h5>نص تجريبي نص تجريبي نص تجريبي </h5>
                                            <h5>هذا النص هو مثال لنص يمكن أن يستبدل في نفس المساحة، لقد تم توليد هذا النص من مولد النص العربى</h5>
                                            <div class="row">
                                                <ul class="first ">
                                                    <li>
                                                        <h5>3.3 DR </h5>
                                                    </li>
                                                    <li>
                                                        <h5>56513 </h5>
                                                    </li>
                                                    <li>
                                                        <h5>جاهز للنقل</h5>
                                                    </li>
                                                </ul>
                                            </div>
                                            <div class="row">
                                                <ul class="second ">
                                                    <li>
                                                        <h6>39,194  قدم مربع  </h6>
                                                    </li>
                                                    <li>
                                                        <h6>المساحة نص تجريبي </h6>
                                                    </li>
                                                    <li>
                                                        <h6>حالة البناء   </h6>
                                                    </li>
                                                </ul>
                                            </div>
                                            <div class="buildingsBtn">
                                                <div class="row">
                                                    <div class="col m4  ">
                                                        <a class="waves-effect waves-light btn" style="background-color: #818287">المزيد </a>
                                                    </div>
                                                    <div class="col m4 ">
                                                        <a class="waves-effect waves-light orange btn">طلب الآن </a>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="buildingCard">
                                <div class="row">
                                    <div class="col m4 l4">
                                        <div class='buldImg'>
                                            <!-- image -->
                                            <img src='/content/MasknVr1/img/building.png' class="img-responsive" alt="" title="build" />
                                            <!-- description div -->
                                            <div class='description'>
                                                <!-- description content -->
                                                <h6 class='description_content'>نص تجريبي ( تجريبي ) </h6>
                                                <fieldset class="rating">
                                                    <input type="radio" id="star19" name="rating" value="5" />
                                                    <label class="full" for="star19" title="5 stars "></label>
                                                    <input type="radio" id="star18" name="rating" value="4" />
                                                    <label class="full" for="star18" title="4 stars "></label>
                                                    <input type="radio" id="star17" name="rating" value="3" />
                                                    <label class="full" for="star17" title="3 stars "></label>
                                                    <input type="radio" id="star16" name="rating" value="2" />
                                                    <label class="full" for="star16" title=" 2 stars"></label>
                                                    <input type="radio" id="star15" name="rating" value="1" />
                                                    <label class="full" for="star15" title="Bad 1 star"></label>
                                                </fieldset>
                                                <a href="#" class="fav "><i class="material-icons ">favorite_border</i> </a>
                                                <!-- end description content -->
                                            </div>
                                            <!-- end description div -->
                                        </div>
                                    </div>
                                    <div class="col m8 l8">
                                        <div class="BuildRight">
                                            <h5>نص تجريبي نص تجريبي نص تجريبي </h5>
                                            <h5>هذا النص هو مثال لنص يمكن أن يستبدل في نفس المساحة، لقد تم توليد هذا النص من مولد النص العربى</h5>
                                            <div class="row">
                                                <ul class="first ">
                                                    <li>
                                                        <h5>3.3 DR </h5>
                                                    </li>
                                                    <li>
                                                        <h5>56513 </h5>
                                                    </li>
                                                    <li>
                                                        <h5>جاهز للنقل   </h5>
                                                    </li>
                                                </ul>
                                            </div>
                                            <div class="row">
                                                <ul class="second ">
                                                    <li>
                                                        <h6>39,194  قدم مربع  </h6>
                                                    </li>
                                                    <li>
                                                        <h6>المساحة نص تجريبي </h6>
                                                    </li>
                                                    <li>
                                                        <h6>حالة البناء   </h6>
                                                    </li>
                                                </ul>
                                            </div>
                                            <div class="buildingsBtn">
                                                <div class="row">
                                                    <div class="col m4  ">
                                                        <a class="waves-effect waves-light btn" style="background-color: #818287">المزيد </a>
                                                    </div>
                                                    <div class="col m4 ">
                                                        <a class="waves-effect waves-light orange btn">طلب الآن </a>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="buildingCard">
                                <div class="row">
                                    <div class="col m4 l4">
                                        <div class='buldImg'>
                                            <!-- image -->
                                            <img src='/content/MasknVr1/img/building.png' class="img-responsive" alt="" title="build" />
                                            <!-- description div -->
                                            <div class='description'>
                                                <!-- description content -->
                                                <h6 class='description_content'>Square Yards  (AGENT)</h6>
                                                <fieldset class="rating">
                                                    <input type="radio" id="star13" name="rating" value="5" />
                                                    <label class="full" for="star13" title="5 stars"></label>

                                                    <input type="radio" id="star12half" name="rating" value="4 and a half" />
                                                    <label class="half" for="star12half" title="4.5 stars"></label>

                                                    <input type="radio" id="star12" name="rating" value="4" />
                                                    <label class="full" for="star12" title="4 stars"></label>

                                                    <input type="radio" id="star11half" name="rating" value="3 and a half" />
                                                    <label class="half" for="star11half" title=" 3.5 stars"></label>

                                                    <input type="radio" id="star10" name="rating" value="3" />
                                                    <label class="full" for="star10" title="3 stars"></label>

                                                    <input type="radio" id="star9half" name="rating" value="2 and a half" />
                                                    <label class="half" for="star9half" title="2.5 stars"></label>

                                                    <input type="radio" id="star9" name="rating" value="2" />
                                                    <label class="full" for="star9" title=" 2 stars"></label>

                                                    <input type="radio" id="star8half" name="rating" value="1 and a half" />
                                                    <label class="half" for="star8half" title=" 1.5 stars"></label>

                                                    <input type="radio" id="star8" name="rating" value="1" />
                                                    <label class="full" for="star8" title="Bad  1 star"></label>

                                                    <input type="radio" id="star7half" name="rating" value="half" />
                                                    <label class="half" for="star7half" title="So Bad 0.5 stars"></label>
                                                </fieldset>
                                                <a href="#" class="fav"><i class="material-icons ">favorite_border</i> </a>
                                            </div>

                                        </div>
                                    </div>
                                    <div class="col m8 l8">
                                        <div class="BuildRight">
                                            <h5>4 BHK Villa in Prestige Mayberry</h5>
                                            <h5>Whitefield Hope Farm Junction, Bangalore</h5>
                                            <div class="row">
                                                <ul class="first ">
                                                    <li>
                                                        <h5>3.3 DR </h5>
                                                    </li>
                                                    <li>
                                                        <h5>56513 </h5>
                                                    </li>
                                                    <li>
                                                        <h5>Ready to move  </h5>
                                                    </li>
                                                </ul>
                                            </div>
                                            <div class="row">
                                                <ul class="second ">
                                                    <li>
                                                        <h6>39,194 / sq ft </h6>
                                                    </li>
                                                    <li>
                                                        <h6>Area in sq ft </h6>
                                                    </li>
                                                    <li>
                                                        <h6>Construction Status  </h6>
                                                    </li>
                                                </ul>
                                            </div>
                                            <div class="buildingsBtn">
                                                <div class="row">
                                                    <div class="col m4  ">
                                                        <a class="waves-effect waves-light btn" style="background-color: #818287">Read More</a>
                                                    </div>
                                                    <div class="col m4 ">
                                                        <a class="waves-effect waves-light orange btn">Connect Now</a>
                                                    </div>

                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="buildingCard">
                                <div class="row">
                                    <div class="col m4 l4">
                                        <div class='buldImg'>
                                            <!-- image -->
                                            <img src='/content/MasknVr1/img/building.png' class="img-responsive" alt="" title="build" />
                                            <!-- description div -->
                                            <div class='description'>
                                                <!-- description content -->
                                                <h6 class='description_content'>Square Yards  (AGENT)</h6>
                                                <fieldset class="rating">
                                                    <input type="radio" id="star6" name="rating" value="5" />
                                                    <label class="full" for="star6" title="5 start"></label>

                                                    <input type="radio" id="star5half" name="rating" value="4 and a half" />
                                                    <label class="half" for="star5half" title="4.5 stars "></label>

                                                    <input type="radio" id="star5" name="rating" value="4" />
                                                    <label class="full" for="star5" title="4 stars "></label>

                                                    <input type="radio" id="star4half" name="rating" value="3 and a half" />
                                                    <label class="half" for="star4half" title=" 3.5 stars "></label>

                                                    <input type="radio" id="star4" name="rating" value="3" />
                                                    <label class="full" for="star4" title="3 stars"></label>

                                                    <input type="radio" id="star3half" name="rating" value="2 and a half" />
                                                    <label class="half" for="star3half" title=" 2.5 stars"></label>

                                                    <input type="radio" id="star3" name="rating" value="2" />
                                                    <label class="full" for="star3" title="2 stars"></label>

                                                    <input type="radio" id="star2half" name="rating" value="1 and a half" />
                                                    <label class="half" for="star2half" title="1.5 stars"></label>

                                                    <input type="radio" id="star2" name="rating" value="1" />
                                                    <label class="full" for="star2" title="bad  1 star"></label>

                                                    <input type="radio" id="star1half" name="rating" value="half" />
                                                    <label class="half" for="star1half" title="So Bad  0.5 stars"></label>
                                                </fieldset>
                                                <a href="#" class="fav"><i class="material-icons ">favorite_border</i> </a>
                                                <!-- end description content -->
                                            </div>
                                            <!-- end description div -->
                                        </div>
                                    </div>
                                    <div class="col m8 l8">
                                        <div class="BuildRight">
                                            <h5>4 BHK Villa in Prestige Mayberry</h5>
                                            <h5>Whitefield Hope Farm Junction, Bangalore</h5>
                                            <div class="row">
                                                <ul class="first ">
                                                    <li>
                                                        <h5>3.3 DR </h5>
                                                    </li>
                                                    <li>
                                                        <h5>56513 </h5>
                                                    </li>
                                                    <li>
                                                        <h5>Ready to move  </h5>
                                                    </li>
                                                </ul>
                                            </div>
                                            <div class="row">
                                                <ul class="second ">
                                                    <li>
                                                        <h6>39,194 / sq ft </h6>
                                                    </li>
                                                    <li>
                                                        <h6>Area in sq ft </h6>
                                                    </li>
                                                    <li>
                                                        <h6>Construction Status  </h6>
                                                    </li>
                                                </ul>
                                            </div>
                                            <div class="buildingsBtn">
                                                <div class="row">
                                                    <div class="col m4  ">
                                                        <a class="waves-effect waves-light btn" style="background-color: #818287">Read More</a>
                                                    </div>
                                                    <div class="col m4 ">
                                                        <a class="waves-effect waves-light orange btn">Connect Now</a>
                                                    </div>

                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="buildingCard">
                                <div class="row">
                                    <div class="col m4 l4">
                                        <div class='buldImg'>
                                            <!-- image -->
                                            <img src='/content/MasknVr1/img/building.png' class="img-responsive" alt="" title="build" />
                                            <!-- description div -->
                                            <div class='description'>
                                                <!-- description content -->
                                                <h6 class='description_content'>Square Yards  (AGENT)</h6>
                                                <fieldset class="rating">
                                                    <input type="radio" id="star30" name="rating" value="5" />
                                                    <label class="full" for="star30" title="5 start"></label>

                                                    <input type="radio" id="star29half" name="rating" value="4 and a half" />
                                                    <label class="half" for="star29half" title="4.5 stars "></label>

                                                    <input type="radio" id="star29" name="rating" value="4" />
                                                    <label class="full" for="star29" title="4 stars "></label>

                                                    <input type="radio" id="star28half" name="rating" value="3 and a half" />
                                                    <label class="half" for="star28half" title=" 3.5 stars "></label>

                                                    <input type="radio" id="star28" name="rating" value="3" />
                                                    <label class="full" for="star28" title="3 stars"></label>

                                                    <input type="radio" id="star27half" name="rating" value="2 and a half" />
                                                    <label class="half" for="star27half" title=" 2.5 stars"></label>

                                                    <input type="radio" id="star27" name="rating" value="2" />
                                                    <label class="full" for="star27" title="2 stars"></label>

                                                    <input type="radio" id="star26half" name="rating" value="1 and a half" />
                                                    <label class="half" for="star26half" title="1.5 stars"></label>

                                                    <input type="radio" id="star26" name="rating" value="1" />
                                                    <label class="full" for="star26" title="bad  1 star"></label>

                                                    <input type="radio" id="star25half" name="rating" value="half" />
                                                    <label class="half" for="star25half" title="So Bad  0.5 stars"></label>
                                                </fieldset>
                                                <a href="#" class="fav active"><i class="material-icons ">favorite_border</i> </a>
                                                <!-- end description content -->
                                            </div>
                                            <!-- end description div -->
                                        </div>
                                    </div>
                                    <div class="col m8 l8">
                                        <div class="BuildRight">
                                            <h5>4 BHK Villa in Prestige Mayberry</h5>
                                            <h5>Whitefield Hope Farm Junction, Bangalore</h5>
                                            <div class="row">
                                                <ul class="first ">
                                                    <li>
                                                        <h5>3.3 DR </h5>
                                                    </li>
                                                    <li>
                                                        <h5>56513 </h5>
                                                    </li>
                                                    <li>
                                                        <h5>Ready to move  </h5>
                                                    </li>
                                                </ul>
                                            </div>
                                            <div class="row">
                                                <ul class="second ">
                                                    <li>
                                                        <h6>39,194 / sq ft </h6>
                                                    </li>
                                                    <li>
                                                        <h6>Area in sq ft </h6>
                                                    </li>
                                                    <li>
                                                        <h6>Construction Status  </h6>
                                                    </li>
                                                </ul>
                                            </div>
                                            <div class="buildingsBtn">
                                                <div class="row">
                                                    <div class="col m4  ">
                                                        <a class="waves-effect waves-light btn" style="background-color: #818287">Read More</a>
                                                    </div>
                                                    <div class="col m4 ">
                                                        <a class="waves-effect waves-light orange btn">Connect Now</a>
                                                    </div>

                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col s12 m4">
                        <div class="buildingLeftPart">
                            <div class="card wow slideInLeft" data-wow-duration="2s" data-wow-delay=".9s">
                                <div class="card-content">
                                    <div class="row">
                                        <div class="col l12 m12 s12">
                                            <div class="media ">
                                                <div class="media-body" style="float: right; width: 70%; text-align: right">
                                                    <h5>نص تجريبي </h5>
                                                    <p style="width: 70%;">نص تجريبي </p>
                                                    <a href="#" style="color: #ff8d0d;">
                                                        <h6 style="font-size: 17px; text-align: right">مشاركة المتطلبات  </h6>
                                                    </a>

                                                </div>
                                                <a href="#" style="float: left!important; text-align: left; padding-top: 20px;">
                                                    <img class="media-object img-responsive" alt="img" src="/content/MasknVr1/img/pyr.png">
                                                </a>
                                            </div>
                                        </div>
                                        <div class="clearfix"></div>
                                    </div>

                                </div>
                            </div>
                            <div class="card wow slideInLeft" data-wow-duration="2s" data-wow-delay=".9s">
                                <div class="card-content">
                                    <div class="row">
                                        <div class="col l12 m12 s12">
                                            <div class="media ">
                                                <div class="media-body" style="float: right; width: 70%; text-align: right">
                                                    <h5>نص تجريبي </h5>
                                                    <p style="width: 70%;">نص تجريبي </p>
                                                    <a href="#" style="color: #ff8d0d;">
                                                        <h6 style="font-size: 17px; text-align: right">مشاركة المتطلبات  </h6>
                                                    </a>
                                                </div>
                                                <a href="#" style="float: left!important; text-align: left; padding-top: 20px;">
                                                    <img class="media-object img-responsive" alt="img" src="/content/MasknVr1/img/pyr.png">
                                                </a>
                                            </div>
                                        </div>
                                        <div class="clearfix"></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
