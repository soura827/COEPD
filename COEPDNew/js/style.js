// JavaScript Document

// Recent Updates Start
$(window).scroll(function() {    
    var scroll = $(window).scrollTop();

    if (scroll >= 200) {
        $(".men").addClass("color1");
    } else {
        $(".men").removeClass("color1");
    }
});

var terms = ["Chennai BA Workshop New batch starts on 5th Dec-2015, For more details call Helpdesk @ +91 89393 73021.", " Hyderabad  BA Daily Trainings New Batch starts on 30-Nov-2015, For more details call Helpdesk @ +91 9000155700.", " Banglore BA Workshop New batch starts on 12-Dec-2015, For more details call Helpdesk @ +91 8374465444","Chennai BA Workshop New batch starts on 5th Dec-2015, For more details call Helpdesk @ +91 89393 73021."," Hyderabad BA Free Seminar Free seminar by Industry Expert on 29-Nov-2015 , For more details call Helpdesk @ +91 9000155700"];

function rotateTerm() {
    var ct = $("#rotate").data("term") || 0;
    $("#rotate").data("term", ct == terms.length -1 ? 0 : ct + 1).text(terms[ct]).fadeIn()
                .delay(3000).fadeOut(200, rotateTerm);
}
$(rotateTerm);1

// Recent Updates End
// Slider Start

var _gaq = _gaq || [];
_gaq.push(['_setAccount', 'UA-36251023-1']);
_gaq.push(['_setDomainName', 'jqueryscript.net']);
_gaq.push(['_trackPageview']);

(function() {
    var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
    var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
})();

// Slider End


(function($){
    $.fn.extend({ 
        rotaterator: function(options) {
 
            var defaults = {
                fadeSpeed: 500,
                pauseSpeed: 500,
                child:null
            };
             
            var options = $.extend(defaults, options);
         
            return this.each(function() {
                var o =options;
                var obj = $(this);                
                var items = $(obj.children(), obj);
                items.each(function() {$(this).hide();})
                if(!o.child){var next = $(obj).children(':first');
                }else{var next = o.child;
                }
                $(next).fadeIn(o.fadeSpeed, function() {
                    $(next).delay(o.pauseSpeed).fadeOut(o.fadeSpeed, function() {
                        var next = $(this).next();
                        if (next.length == 0){
                            next = $(obj).children(':first');
                        }
                        $(obj).rotaterator({child : next, fadeSpeed : o.fadeSpeed, pauseSpeed : o.pauseSpeed});
                    })
                });
            });
        }
    });
})(jQuery);

$(document).ready(function() {
    $('#rotate-text').rotaterator({fadeSpeed:500, pauseSpeed:2000});
});
 
// Validating Empty Field
function check_empty() {
    if (document.getElementById('name').value == "" || document.getElementById('email').value == "" || document.getElementById('msg').value == "") {
        alert("Fill All Fields !");
    } else {
        document.getElementById('form').submit();
        alert("Form Submitted Successfully...");
    }
}
//Function To Display Popup
function div_show() {
    document.getElementById('abc').style.display = "block";
}
//Function to Hide Popup
function div_hide(){
    document.getElementById('abc').style.display = "none";
}
 
//Inner page images slider
;(function(factory) {
    if(typeof define === 'function' && define.amd) {
        define(['jquery'], factory);
    }
    else if(typeof exports === 'object') {
        module.exports = factory(require('jquery'));
    }
    else {
        factory(jQuery);
    }
}
(function($) {
    var pluginName = "tinycarousel"
    ,   defaults   =
        {
            start: 0
        ,   axis: "x"
        ,   buttons: true
        ,   bullets: false
        ,   interval: false
        ,   intervalTime: 3000
        ,   animation: true
        ,   animationTime: 1000
        ,   infinite: true
        }
    ;

    function Plugin($container, options) {
        /**
         * The options of the carousel extend with the defaults.
         *
         * @property options
         * @type Object
         * @default defaults
         */
        this.options = $.extend({}, defaults, options);

        /**
         * @property _defaults
         * @type Object
         * @private
         * @default defaults
         */
        this._defaults = defaults;

        /**
         * @property _name
         * @type String
         * @private
         * @final
         * @default 'tinycarousel'
         */
        this._name = pluginName;

        var self = this
        ,   $viewport = $container.find(".viewport:first")
        ,   $overview = $container.find(".overview:first")
        ,   $slides = null
        ,   $next = $container.find(".next:first")
        ,   $prev = $container.find(".prev:first")
        ,   $bullets = $container.find(".bullet")

        ,   viewportSize = 0
        ,   contentStyle = {}
        ,   slidesVisible = 0
        ,   slideSize = 0
        ,   slideIndex = 0

        ,   isHorizontal = this.options.axis === 'x'
        ,   sizeLabel = isHorizontal ? "Width" : "Height"
        ,   posiLabel = isHorizontal ? "left" : "top"
        ,   intervalTimer = null
        ;

        /**
         * The index of the current slide.
         *
         * @property slideCurrent
         * @type Number
         * @default 0
         */
        this.slideCurrent = 0;

        /**
         * The number of slides the carousel is currently aware of.
         *
         * @property slidesTotal
         * @type Number
         * @default 0
         */
        this.slidesTotal = 0;

        /**
         * If the interval is running the value will be true.
         *
         * @property intervalActive
         * @type Boolean
         * @default false
         */
        this.intervalActive = false;

        /**
         * @method _initialize
         * @private
         */
        function _initialize() {
            self.update();
            self.move(self.slideCurrent);

            _setEvents();

            return self;
        }

        /**
         * You can use this method to add new slides on the fly. Or to let the carousel recalculate itself.
         *
         * @method update
         * @chainable
         */
        this.update = function() {
            $overview.find(".mirrored").remove();

            $slides = $overview.children();
            viewportSize = $viewport[0]["offset" + sizeLabel];
            slideSize = $slides.first()["outer" + sizeLabel](true);
            self.slidesTotal = $slides.length;
            self.slideCurrent = self.options.start || 0;
            slidesVisible = Math.ceil(viewportSize / slideSize);

            $overview.append($slides.slice(0, slidesVisible).clone().addClass("mirrored"));
            $overview.css(sizeLabel.toLowerCase(), slideSize * (self.slidesTotal + slidesVisible));

            _setButtons();

            return self;
        };

        /**
         * @method _setEvents
         * @private
         */
        function _setEvents() {
            if(self.options.buttons) {
                $prev.click(function() {
                    self.move(--slideIndex);

                    return false;
                });

                $next.click(function() {
                    self.move(++slideIndex);

                    return false;
                });
            }

            $(window).resize(self.update);

            if(self.options.bullets) {
                $container.on("click", ".bullet", function() {
                    self.move(slideIndex = +$(this).attr("data-slide"));

                    return false;
                });
            }
        }


        /**
         * If the interval is stoped start it.
         *
         * @method start
         * @chainable
         */
        this.start = function() {
            if(self.options.interval) {
                clearTimeout(intervalTimer);

                self.intervalActive = true;

                intervalTimer = setTimeout(function() {
                    self.move(++slideIndex);

                }, self.options.intervalTime);
            }

            return self;
        };

        /**
         * If the interval is running stop it.
         *
         * @method start
         * @chainable
         */
        this.stop = function() {
            clearTimeout(intervalTimer);

            self.intervalActive = false;

            return self;
        };

        /**
         * Move to a specific slide.
         *
         * @method move
         * @chainable
         * @param {Number}  [index] The slide to move to.
         */
        this.move = function(index) {
            slideIndex = isNaN(index) ? self.slideCurrent : index;
            self.slideCurrent = slideIndex % self.slidesTotal;

            if(slideIndex < 0) {
                self.slideCurrent = slideIndex = self.slidesTotal - 1;
                $overview.css(posiLabel, -(self.slidesTotal) * slideSize);
            }

            if(slideIndex > self.slidesTotal) {
                self.slideCurrent = slideIndex = 1;
                $overview.css(posiLabel, 0);
            }
            contentStyle[posiLabel] = -slideIndex * slideSize;

            $overview.animate(
                contentStyle
            ,   {
                queue : false
                ,   duration : self.options.animation ? self.options.animationTime : 0
                ,   always : function() {
                    /**
                     * The move event will trigger when the carousel slides to a new slide.
                     *
                     * @event move
                     */
                    $container.trigger("move", [$slides[self.slideCurrent], self.slideCurrent]);
                }
            });

            _setButtons();
            self.start();

            return self;
        };

        /**
         * @method _setButtons
         * @private
         */
        function _setButtons() {
            if(self.options.buttons && !self.options.infinite) {
                $prev.toggleClass("disable", self.slideCurrent <= 0);
                $next.toggleClass("disable", self.slideCurrent >= self.slidesTotal - slidesVisible);
            }

            if(self.options.bullets) {
                $bullets.removeClass("active");
                $($bullets[self.slideCurrent]).addClass("active");
            }
        }

        return _initialize();
    }

    /**
    * @class tinycarousel
    * @constructor
    * @param {Object} options
        @param {Number}  [options.start=0] The slide to start with.
        @param {String}  [options.axis=x] Vertical or horizontal scroller? ( x || y ).
        @param {Boolean} [options.buttons=true] Show previous and next navigation buttons.
        @param {Boolean} [options.bullets=false] Is there a page number navigation present?
        @param {Boolean} [options.interval=false] Move to another block on intervals.
        @param {Number}  [options.intervalTime=3000] Interval time in milliseconds.
        @param {Boolean} [options.animate=true] False is instant, true is animate.
        @param {Number}  [options.animationTime=1000] How fast must the animation move in ms?
        @param {Boolean} [options.infinite=true] Infinite carousel.
    */
    $.fn[pluginName] = function(options) {
        return this.each(function() {
            if(!$.data(this, "plugin_" + pluginName)) {
                $.data(this, "plugin_" + pluginName, new Plugin($(this), options));
            }
        });
    };
}));


$(document).ready(function()
{
    $('#slider1').tinycarousel();
});

// Faq Page Js Start
//Accordian Action
var action = 'click';
var speed = "500";
//Document.Ready
$(document).ready(function(){
    //Question handler
    $('li.q').on(action, function(){
        //gets next element
        //opens .a of selected question
        $(this).next().slideToggle(speed)
            //selects all other answers and slides up any open answer
            .siblings('li.a').slideUp();
        var img = $(this).children('img');
        $('img').not(img).removeClass('rotate');
        //toggle rotate class
        img.toggleClass('rotate');
    });//End on click
});//End Ready

// Faq Page Js End

// New Css Js Start
(function($) {

    $.fn.menumaker = function(options) {
      
        var cssmenu = $(this), settings = $.extend({
            title: "Menu",
            format: "dropdown",
            sticky: false
        }, options);

        return this.each(function() {
            cssmenu.prepend('<div id="menu-button">' + settings.title + '</div>');
            $(this).find("#menu-button").on('click', function(){
                $(this).toggleClass('menu-opened');
                var mainmenu = $(this).next('ul');
                if (mainmenu.hasClass('open')) { 
                    mainmenu.hide().removeClass('open');
                }
                else {
                    mainmenu.show().addClass('open');
                    if (settings.format === "dropdown") {
                        mainmenu.find('ul').show();
                    }
                }
            });

            cssmenu.find('li ul').parent().addClass('has-sub');

            multiTg = function() {
                cssmenu.find(".has-sub").prepend('<span class="submenu-button"></span>');
                cssmenu.find('.submenu-button').on('click', function() {
                    $(this).toggleClass('submenu-opened');
                    if ($(this).siblings('ul').hasClass('open')) {
                        $(this).siblings('ul').removeClass('open').hide();
                    }
                    else {
                        $(this).siblings('ul').addClass('open').show();
                    }
                });
            };

            if (settings.format === 'multitoggle') multiTg();
            else cssmenu.addClass('dropdown');

            if (settings.sticky === true) cssmenu.css('position', 'fixed');

            resizeFix = function() {
                if ($( window ).width() > 768) {
                    cssmenu.find('ul').show();
                }

                if ($(window).width() <= 768) {
                    cssmenu.find('ul').hide().removeClass('open');
                }
            };
            resizeFix();
            return $(window).on('resize', resizeFix);

        });
    };
})(jQuery);

(function($){
    $(document).ready(function(){

        $("#cssmenu").menumaker({
            title: "Menu",
            format: "multitoggle"
        });

    });
})(jQuery);

// New Css Js End

// Meha menu Js StartEnd


$(function() {
    window.prettyPrint && prettyPrint()
    $(document).on('click', '.yamm .dropdown-menu', function(e) {
        e.stopPropagation()
    })
})

// Meha menu Js StartEnd //