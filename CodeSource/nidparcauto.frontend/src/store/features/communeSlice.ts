import { createAsyncThunk, createSlice } from '@reduxjs/toolkit'
import type { PayloadAction } from '@reduxjs/toolkit'
import type { RootState } from '../store'
import { CommunesInterface } from '../../types/InterfacesTypes'
import { AllCommunes } from '../../endpoints/commune'

// Define a type for the slice state
interface communeState {
  isLoading: boolean;
  data: CommunesInterface[] | null;
  isError: boolean;
}

export const fetchCommunes = createAsyncThunk("fetchCommunes", async () => {
  const response = await fetch(AllCommunes);
  return response.json()
})




//Define the initial state using that type
const initialState: communeState = {
  isLoading: false,
  data: null,
  isError: false
}

export const communeSlice = createSlice({
  name: 'commune',
  // `createSlice` will infer the state type from the `initialState` argument
  initialState,
  reducers: {},
  extraReducers: (builder) => {
    builder.addCase(fetchCommunes.pending, (state, action) => {
      state.isLoading = true;
      console.log('pending ' + action)
    });
    builder.addCase(fetchCommunes.fulfilled, (state, action) => {
      state.isLoading = false;
      state.data = action.payload;
      console.log('fuldilled ' + action)

    });
    builder.addCase(fetchCommunes.rejected, (state, action) => {
      console.log('Error', action.payload)
      state.isError =  true
      console.log('rejected ' + action)

    });
  }
});

// export const { } = communeSlice.actions

// Other code such as selectors can use the imported `RootState` type
export const selectCommune = (state: RootState) => state.communes

export default communeSlice.reducer;