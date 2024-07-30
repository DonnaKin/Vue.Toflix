import { createRouter, createWebHistory, RouteRecordRaw } from "vue-router";

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

export default router;
