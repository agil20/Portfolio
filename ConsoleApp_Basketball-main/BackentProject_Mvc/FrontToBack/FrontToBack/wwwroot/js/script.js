$(document).ready(function () {

    // HEADER

    $(document).on('click', '#search', function () {
        $(this).next().toggle();
    })

    $(document).on('click', '#mobile-navbar-close', function () {
        $(this).parent().removeClass("active");

    })
    $(document).on('click', '#mobile-navbar-show', function () {
        $('.mobile-navbar').addClass("active");

    })
    //search
    $(document).on("keyup", "#input-search", function ()
    
    {
        let inputValue = $(this).val();
        $("#searchList li ").slice(1).remove()
            $.ajax({
                url: "home/searchProduct?search="+inputValue ,
                method: "get",
                success: function (res) {
                    $("#searchList" ).append(res);
                }
            })

        }

    )
 


    //loadmore
     let skip = 2;
    $(document).on('click', '#loadMore', function () {
        let productCount = $("#productCount")
        let productList = $("#productList");

        $.ajax({
            url: "/product/loadmore?skip="+skip,
            method: "get",
            success: function (res) {
                console.log(res)
                productList.append(res);
                skip += 2
                console.log(productCount)
            }
        })
        if (skip>=productCount.val()) {
            $("#loadMore").remove();
     
        }

    })
  
 




    $(document).on('click', '.mobile-navbar ul li a', function () {
        if ($(this).children('i').hasClass('fa-caret-right')) {
            $(this).children('i').removeClass('fa-caret-right').addClass('fa-sort-down')
        }
        else {
            $(this).children('i').removeClass('fa-sort-down').addClass('fa-caret-right')
        }
        $(this).parent().next().slideToggle();
    })

    // SLIDER

    $(document).ready(function(){
        $(".slider").owlCarousel(
            {
                items: 1,
                loop: true,
                autoplay: true
            }
        );
    });
   
 

    // PRODUCT

    $(document).on('click', '.categories', function(e)
    {
        e.preventDefault();
        $(this).next().next().slideToggle();
     
    })

    $(document).on('click', '.category li a', function (e) {
        e.preventDefault();
    
        let category = $(this).attr('data-id');
        let products = $('.product-item');
      
        products.each(function () {
            if(category == $(this).attr('data-id'))
            {
                $(this).parent().fadeIn();
            }
            else
            {
                $(this).parent().hide();
            }
        })
        if(category == 'all')
        {
            products.parent().fadeIn();
        }
    })

    // ACCORDION 

    $(document).on('click', '.question', function()
    {   
       $(this).siblings('.question').children('i').removeClass('fa-minus').addClass('fa-plus');
       $(this).siblings('.answer').not($(this).next()).slideUp();
       $(this).children('i').toggleClass('fa-plus').toggleClass('fa-minus');
       $(this).next().slideToggle();
       $(this).siblings('.active').removeClass('active');
       $(this).toggleClass('active');
    })

    // TAB

    $(document).on('click', 'ul li', function()
    {   
        $(this).siblings('.active').removeClass('active');
        $(this).addClass('active');
        let dataId = $(this).attr('data-id');
        $(this).parent().next().children('p.active').removeClass('active');

        $(this).parent().next().children('p').each(function()
        {
            if(dataId == $(this).attr('data-id'))
            {
                $(this).addClass('active')
            }
        })
    })

    $(document).on('click', '.tab4 ul li', function()
    {   
        $(this).siblings('.active').removeClass('active');
        $(this).addClass('active');
        let dataId = $(this).attr('data-id');
        $(this).parent().parent().next().children().children('p.active').removeClass('active');

        $(this).parent().parent().next().children().children('p').each(function()
        {
            if(dataId == $(this).attr('data-id'))
            {
                $(this).addClass('active')
            }
        })
    })

    // INSTAGRAM

    $(document).ready(function(){
        $(".instagram").owlCarousel(
            {
                items: 4,
                loop: true,
                autoplay: true,
                responsive:{
                    0:{
                        items:1
                    },
                    576:{
                        items:2
                    },
                    768:{
                        items:3
                    },
                    992:{
                        items:4
                    }
                }
            }
        );
    });
    //sale
    $("#submitId").each(function (index) {
        $(this).on("click", function () {
          
            $(this).prev().prev().parent().remove();
         

           


        });
    });
    //plus
   
    $(".plusTd").each(function (index) {
     $(this).on("click", function () {
         let Id = $(this).data().value
       
         let mythis = $(this)
        
   
         $.ajax({
             url: "/basket/Plus?id=" + Id,
             method: "get",
             success: function (res) {
               
                 mythis.parent().prev().text(`${res.productSum}`) 
                 mythis.prev().text(`${res.productCount}`) 
                 mythis.parent().prev().prev().text(`${res.productCount}`) 
        
                
             }
         })
       
       
        });
    });
    //minus

    $(".minusTd").each(function (index) {
        $(this).on("click", function () {
            let Id = $(this).data().value

            let mythis = $(this)
         
           
            $.ajax({
                url: "/basket/Minus?id=" + Id,
                method: "get",
                success: function (res) {
                    
                    mythis.next().text(`${res.productCount}`)
                    mythis.parent().prev().text(`${res.productSum}`) 
                    mythis.parent().prev().prev().text(`${res.productCount}`)  
                    if (res.productCount == 0) {
                        mythis.parent().parent().remove();
                    }
                 
               
                    
                }
            })


        });
    });

      $(document).ready(function(){
        $(".say").owlCarousel(
            {
                items: 1,
                loop: true,
                autoplay: true
            }
        );
      });
})




const removeBtns = document.querySelectorAll(".closeList");

removeBtns.forEach(btn => {
    let productCount = document.getElementById("productCount")
    function handleRemoveElement() {
        let btnId = btn.getAttribute("data-value")
  
        axios.get("/basket/delete?id=" + btnId)
            .then(function (response) {
                console.log(response);
                productCount.innerHTML = response.data
            })
            .catch(function (error) {
              
                console.log(error);
            })
        this.parentElement.remove();
    }
    btn.addEventListener("click",handleRemoveElement)
})
