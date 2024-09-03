<template>
  <div id="container">
    <div class="login_wrap">
      <div class="form_group">
        <h2>LOGIN</h2>
        <form>
          <div class="form_floating">
            <!-- .valid / .error -->
            <input
              type="text"
              id="id"
              class="form_input valid error"
              v-model="uid"
            />
            <label for="id">이메일 주소 또는 휴대폰 번호</label>
            <div class="error_message">
              정확한 이메일 주소나 전화번호를 입력하세요.
            </div>
          </div>
          <div class="form_floating">
            <input
              type="password"
              id="password"
              class="form_input"
              v-model="password"
            />
            <label for="password">비밀번호</label>
            <div class="error_message">비밀번호는 4~60자 사이여야 합니다.</div>
          </div>
          <button type="button" class="btn btn_primary" @click="Login">
            로그인
          </button>
          <div class="form_check">
            <input type="checkbox" id="saveCheck" />
            <label for="saveCheck">로그인 정보 저장</label>
          </div>
        </form>
      </div>
    </div>
  </div>
</template>

<script lang="ts" setup>
import { onMounted, reactive, ref } from "vue";
import axios, { AxiosRequestConfig, AxiosResponse } from "axios";
import { useRouter } from "vue-router";
import { LoginResult, Temp } from "@/store";

const uid = ref<string>("");
const password = ref<string>("");

const router = useRouter();

const loginResult = LoginResult();

async function Login() {
  // api 호출 (api 호출은 async로 동작해야함)
  const config = reactive<AxiosRequestConfig>(Object.create(null));
  config.url = "/netflix/api/account/login";
  config.method = "POST";
  config.headers = {
    "Content-Type": "application/json;charset=utf-8",
  };

  // 로그인 데이터 객체
  const loginParam = reactive<LoginParameter>(Object.create(null));
  loginParam.uid = uid.value;
  loginParam.password = password.value;

  config.data = loginParam;

  // api 호출
  await axios(config)
    .then((res: AxiosResponse<LoginResult>) => {
      console.log(res);
      if (res.data.errorCode == "0000") {
        // 로그인 정보를 생성
        // todo: 로그인 정보를 저장한다.
        loginResult.login.data = res.data.data;
        console.log("loginResult : " + loginResult.login.data.watchingList);

        router.push({
          name: "home",
        });
      }
    })
    .catch((err: Error) => {
      console.log("error: " + err);
    })
    .finally(() => {
      console.log("finally");
    });
}
</script>
