import { createStore } from 'vuex'
import httpclient from '@/api/httpclient'

export default createStore({
  strict: true,
  state: {
    evenements: [],
    pageIndex: 1,
    pageCount: 10,
    filtre: ""
  },
  getters: {
  },
  mutations: {
    getEvenementsApi(state, data){
      state.evenements = data
  },
  },
  actions: {
    async getEvenementsApi(context){
      return await httpclient.get('Evenements', {params: {filtre: this.state.filtre, pageIndex: this.state.pageIndex, pageCount: this.state.pageCount}})
      .then(reponse => {
        context.commit('getEvenementsApi', reponse.data)
        return reponse
      })
      .catch(error => {
        console.log(error)
        return Promise.reject(error)
      }) 
    },
  },
  modules: {
  }
})
