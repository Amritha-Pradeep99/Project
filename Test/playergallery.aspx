<%@ Page Title="" Language="C#" MasterPageFile="~/Test/TestMaster.master" AutoEventWireup="true" CodeFile="playergallery.aspx.cs" Inherits="Test_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <!-- CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />
    <style>
        /* Set custom width and height for carousel */
        #carouselExampleFade {
            width: 800px; 
            height: 800px; 
            
            /* You can adjust these values as needed */
        }
        /* Adjust image width and height */
        .carousel-item img {
            width: 100%; 
            height: 650px;
            object-fit: cover; 
        }
        .container {
            margin-top:80px;
        }
    </style>
    <!-- JavaScript -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="container" align="center">
    <div id="carouselExampleFade" class="carousel slide carousel-fade" data-bs-ride="carousel">
  <div class="carousel-inner">
    <% for (int i = 0; i < Images.Count; i++) { %>
                   <div class="carousel-item <%= i == 0 ? "active" : "" %>">
                        <img src="../Assests/Playerdoc/<%= Images[i] %>" class="d-block w-100" alt="...">
                    </div>
                <% } %>

  </div>
  <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleFade" data-bs-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Previous</span>
  </button>
  <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleFade" data-bs-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Next</span>
  </button>
</div>
 </div>
</asp:Content>

 