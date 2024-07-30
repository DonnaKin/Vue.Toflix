<template>
  <Teleport to="#modalLayout">
    <!-- popup -->
    <div id="popup" class="popup" v-show="true">
      <div class="popup_wrap">
        <button type="button" class="btn_close">닫기</button>
        <div class="preview_img_box">
          <img src="/assets/image/img_visual.jpg" alt="기묘한 이야기" />
        </div>
        <div class="preview_info_box">
          <h2 class="title">기묘한 이야기</h2>
          <!-- 찜 클릭 시 .active 클래스 추가 -->
          <button type="button" class="btn_heart">찜</button>
          <div class="tag_box">
            <img src="/assets/image/icon_top_10.png" alt="TOP10" />
            <img src="/assets/image/icon_age_all.png" alt="전체 관람가" />
            <img src="/assets/image/icon_age_12.png" alt="12세 관람가" />
            <img src="/assets/image/icon_age_15.png" alt="15세 관람가" />
            <img src="/assets/image/icon_age_19.png" alt="19세 관람가" />
            <img src="/assets/image/icon_tag_01.png" alt="폭력성" />
            <img src="/assets/image/icon_tag_02.png" alt="대사" />
            <img src="/assets/image/icon_tag_03.png" alt="모방위험" />
            <img src="/assets/image/icon_tag_04.png" alt="약물" />
            <img src="/assets/image/icon_tag_05.png" alt="주제" />
            <img src="/assets/image/icon_tag_06.png" alt="공포" />
          </div>
          <p class="desc">
            친구네 집에서 자신의 집으로 돌아가던 중 윌은 무언가 이상한 것을 보게
            되고, 윌이 있는 곳에서 가까운 정부의 비밀 실험실에서는 끔찍한 일이
            벌어진다.
          </p>
          <div class="detail">
            <ul>
              <li>
                <span>출연 : </span>
                위노나 라이더, 데이비드 하버, 밀리 바비 브라운, 핀 울프하드,
                게이튼 마타라조, 케일럽 맥러플린, 노아 슈냅, 세이디 싱크,
                너탈리아 다이어
              </li>
              <li>
                <span>장르 : </span>
                SF 시리즈, 청소년 시리지, 미국 TV 프로그램, 호러 시리즈
              </li>
              <li>
                <span>시리즈 특징 : </span>
                향수 자극, 불길한, 무서운
              </li>
              <li>
                <span>감독 : </span>
                더퍼형제
              </li>
            </ul>
          </div>
        </div>
      </div>
    </div>
  </Teleport>
</template>

<script lang="ts" setup></script>
