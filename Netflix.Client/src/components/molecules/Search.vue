<template>
  <!-- 검색 결과 없을 때 .hide -->
  <div class="none_data_box hide">
    <div class="text">
      입력하신 검색어 ' <em class="keyword">검색어</em> '(와)과 일치하는 결과가
      없습니다.
    </div>
  </div>
  <!-- 검색 결과 (컨텐츠 목록 - 목록형) .hide -->
  <div class="contents_list_box hide">
    <h3 class="contents_title">
      ' <em class="keyword">검색어</em> '와 관련된 컨텐츠
    </h3>
    <div class="list_wrap type_list">
      <ul>
        <li class="item">
          <a href="#">
            <img src="/assets/image/img_movie_01.jpg" alt="기묘한이야기" />
          </a>
        </li>
      </ul>
    </div>
  </div>
</template>
