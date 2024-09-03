import { createRouter, createWebHistory, RouteRecordRaw } from "vue-router";
import axios, { AxiosRequestConfig, AxiosResponse } from "axios";
import { reactive } from "vue";
import { LoginResult } from "@/store";

const routes = [
  {
    path: "/",
    redirect: "/tofilx/login",
  },
  {
    path: "/tofilx",
    name: "tofilx",
    component: () =>
      import(/* webpackChunkName: "TofilxView" */ "../views/TofilxView.vue"),
    children: [
      {
        path: "home",
        name: "home",
        component: () =>
          import(
            /* webpackChunkName: "Home" */ "../components/organisms/Home.vue"
          ),
      },
      {
        path: "search",
        name: "search",
        component: () =>
          import(
            /* webpackChunkName: "SearchView" */ "../components/organisms/Search.vue"
          ),
      },
      {
        path: "login",
        name: "login",
        component: () =>
          import(
            /* webpackChunkName: "LoginView" */ "../components/organisms/Login.vue"
          ),
      },
    ],
  },
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

router.beforeEach(async (to, from, next) => {
  if (to.name == "home") {
    // api 호출 (api 호출은 async로 동작해야함)
    const config = reactive<AxiosRequestConfig>(Object.create(null));
    config.url = "/netflix/api/account/check";
    config.method = "GET";

    // api 호출
    await axios(config)
      .then((res: AxiosResponse<LoginResult>) => {
        console.log(res);
        next();
      })
      .catch((err: Error) => {
        next({
          name: "login",
        });
      });
  } else {
    next();
  }
});

export default router;
