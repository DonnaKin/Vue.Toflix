import { get, post } from "@/api";

export default {
  TryLogin(param: any): Promise<any> {
    return get<any>({
      url: "/netflix/api/account/login",
    });
  },
  TryLoginPost(param: any): Promise<any> {
    return post<any>({
      url: "/netflix/api/account/login",
    });
  },
};

interface result {
  result: string;
  errorCode: string;
  errorMessage: string;
}
