import { createRouter, createWebHistory, RouteRecordRaw } from "vue-router";

const routes = [
  {
    path: '/',
    redirect: '/tofilx/login'
  },
  {
    path: '/tofilx',
    name: 'tofilx',
    component: () => import(/* webpackChunkName: "TofilxView" */'../views/TofilxView.vue'),
    children:
      [
        {
          path: 'home',
          name: 'home',
          component: () => import(/* webpackChunkName: "MainView" */'../views/MainView.vue'),
          children:
            [
              {
                path: 'search',
                name: 'search',
                component: () => import(/* webpackChunkName: "SearchView" */'../views/SearchView.vue')
              }
            ]
        },
        {
          path: 'login',
          name: 'login',
          component: () => import(/* webpackChunkName: "LoginView" */'../views/LoginView.vue')
        }
      ]
  }
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

export default router;