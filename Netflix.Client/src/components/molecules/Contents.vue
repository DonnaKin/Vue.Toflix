<template>
  <div class="contents_list_box">
    <h3 class="contents_title">시청중인 컨텐츠</h3>
    <div class="list_wrap type_slider slider1">
      <ul class="swiper-wrapper">
        <li
          class="swiper-slide item"
          v-for="(data, index) in watchingList"
          :key="index"
        >
          <a @click="imgClick">
            <img :src="data.mainImg" :alt="data.title" />
          </a>
        </li>
      </ul>
      <div class="btn_nav btn_next"></div>
      <div class="btn_nav btn_prev"></div>
    </div>
    <h3 class="contents_title">내가 찜한 컨텐츠</h3>
    <div class="list_wrap type_slider slider1">
      <ul class="swiper-wrapper">
        <li
          class="swiper-slide item"
          v-for="(data, index) in favoriteList"
          :key="index"
        >
          <a @click="imgClick">
            <img :src="data.mainImg" :alt="data.title" />
          </a>
        </li>
      </ul>
      <div class="btn_nav btn_next"></div>
      <div class="btn_nav btn_prev"></div>
    </div>
  </div>
  <Popup :isShow="isShow" />
</template>

<script lang="ts" setup>
/***********************************************************************************************************/
/*                                             I M P O R T                                                 */
/***********************************************************************************************************/
import Popup from "@/components/molecules/Popup.vue";
import { reactive, ref, onMounted } from "vue";
import axios, { AxiosRequestConfig, AxiosResponse } from "axios";
import { LoginResult } from "@/store";
/***********************************************************************************************************/
/*                                               D A T A                                                   */
/***********************************************************************************************************/
const loginResult = LoginResult();
const contents = reactive<ListData[]>([]);
const seriesList = reactive<ListData[]>([]);
const watchingList = reactive<ListData[]>([]);
const favoriteList = reactive<ListData[]>([]);
/***********************************************************************************************************/
/*                                            C O M P U T E D                                              */
/***********************************************************************************************************/

/***********************************************************************************************************/
/*                                              P R O P S                                                  */
/***********************************************************************************************************/
const isShow = ref<boolean>(false);
/***********************************************************************************************************/
/*                                           L I F E C Y C L E                                             */
/***********************************************************************************************************/

onMounted(async () => {
  // api 호출 (api 호출은 async로 동작해야함)
  const config = reactive<AxiosRequestConfig>(Object.create(null));
  config.url = "/netflix/api/content/items";
  config.method = "GET";
  config.headers = {
    "Content-Type": "application/json;charset=utf-8",
  };

  // api 호출
  await axios(config)
    .then((res: AxiosResponse<List>) => {
      console.log(res.data);
      if (res.data.errorCode == "0000") {
        Object.assign(contents, res.data.data);
        console.log(contents);

        Object.assign(
          seriesList,
          contents.filter((item: ListData) => {
            return item.category == "serise";
          })
        );
        //console.log(seriesList);

        // watchingList
        Object.assign(
          watchingList,
          contents.filter((item: ListData) => {
            if (Array.isArray(item)) {
              return item.some((watchingData) =>
                loginResult.login.data.watchingList.includes(watchingData)
              );
            } else {
              return loginResult.login.data.watchingList.includes(item.code);
            }
          })
        );
        console.log(watchingList);

        // favoriteList
        Object.assign(
          favoriteList,
          contents.filter((item: ListData) => {
            if (Array.isArray(item)) {
              return item.some((favoriteData) =>
                loginResult.login.data.favoriteList.includes(favoriteData)
              );
            } else {
              return loginResult.login.data.favoriteList.includes(item.code);
            }
          })
        );
        console.log(favoriteList);
      }
    })
    .catch((err: Error) => {
      console.log("error: " + err);
    });
});

/***********************************************************************************************************/
/*                                             M E T H O D                                                 */
/***********************************************************************************************************/
function imgClick() {
  // 모달 창 띄우기
  isShow.value = true;
}
/***********************************************************************************************************/
/*                                               E M I T                                                   */
/***********************************************************************************************************/

/***********************************************************************************************************/
/*                                              W A T C H                                                  */
/***********************************************************************************************************/
</script>
