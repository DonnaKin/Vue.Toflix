<template>
    <header id="header">
            <h1 id="logo">
                <a href="#">NETFLIX</a>
            </h1>
            <div class="left_nav">
                <ul>
                    <li><a href="#">홈</a></li>
                    <li><a href="#">시리즈</a></li>
                    <li><a href="#">영화</a></li>
                    <li><a href="#">내가 찜한 리스트</a></li>
                </ul>
            </div>
            <div class="right_nav">
                <div class="search_box">
                    <input type="text" id="search" placeholder="제목, 사람, 장르" autocomplete="off">
                    <label for="search">
                        <span class="icon_search"></span>
                    </label>
                </div>
                <div class="user_box">
                    <span class="profile"><img src="/assets/image/img_profile.png" alt="프로필"></span>
                    <div class="drop_menu">
                        <div class="link_box">
                            <a href="#">로그아웃</a>
                        </div>
                    </div>
                </div>
            </div>
        </header>
</template>